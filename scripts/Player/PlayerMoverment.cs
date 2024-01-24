using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMoverment : MonoBehaviour
{
    private Rigidbody2D body;
    private Animator anim;
    private BoxCollider2D boxCollider;
    private float wallJumpCooldown;
    private float movementvalue;
    [Header("Basic Movement Value")]
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    [Header("Coyote Time")]
    [SerializeField] private float coyateTime;
    private float coyateCounter;
    [Header("Multiple Jump")]
    [SerializeField] private float extraJump;
    private float extraJumpCounter;
    [Header("Wall Jumping")]
    [SerializeField] private float wallJumpX; //Horizontal wall jump force
    [SerializeField] private float wallJumpY; //Vertical wall jump force
    [Header("layer Mark")]
    [SerializeField] private LayerMask groundlayer;
    [SerializeField] private LayerMask wallLayer;
    [Header("Dash Value")]
    [SerializeField] private float dashBoost;
    [SerializeField] private float dashTime;
    private float _dashTime;
    private bool isDashing = false;
    [Header("Sound")]
    [SerializeField] private AudioClip soundDash;

    

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        movementvalue = Input.GetAxis("Horizontal");
        

        if (Input.GetKey(KeyCode.LeftControl) && _dashTime<=0 && isDashing == false)
        {
            Audio.instance.PlaySound(soundDash);
            speed += dashBoost;
            _dashTime = dashTime;
            isDashing = true;
        }
        if (_dashTime <= 0 && isDashing == true)
        {
            speed -= dashBoost;
            isDashing = false;
        } else
        {
            _dashTime -= Time.deltaTime;
        }

        if (movementvalue > 0.01f)
            transform.localScale = Vector3.one;
        else if (movementvalue < -0.01f)
            transform.localScale = new Vector3(-1, 1, 1);



        anim.SetBool("run", movementvalue != 0);
        anim.SetBool("ground", isGrounded());

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }

        if (Input.GetKeyUp(KeyCode.Space) && body.velocity.y > 0)
        {
            body.velocity = new Vector2(body.velocity.x, body.velocity.y / 2);
        
        }

        if (onWall())
        {
            body.gravityScale = 0;
            body.velocity = Vector2.zero;

        } else
        {
            body.gravityScale = 7;
            body.velocity = new Vector2(movementvalue * speed, body.velocity.y);

            if (isGrounded())
            {
                coyateCounter = coyateTime;
                extraJumpCounter = extraJump;
            } else
            {
                coyateCounter -= Time.deltaTime;
            }

        }
    }
    private void jump()
    {
        if ((coyateCounter <= 0) && !onWall() && (extraJumpCounter <= 0)) return;

        if (onWall())
            wallJump(); 
        else
        if (isGrounded())
        {
            body.velocity = new Vector2(body.velocity.x, jumpPower);
        } else
        {
            if (coyateCounter > 0)
            {
                body.velocity = new Vector2(body.velocity.x, jumpPower);
            }
            if (extraJumpCounter > 0)
            {
                body.velocity = new Vector2(body.velocity.x, jumpPower);
                extraJumpCounter--;
            }
            coyateCounter = 0;
        }
    }
    private void wallJump()
    {
        body.AddForce(new Vector2(-Mathf.Sign(transform.localScale.x) * wallJumpX, wallJumpY));
        wallJumpCooldown = 0;
    }

    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center,boxCollider.bounds.size,0,Vector2.down,0.1f,groundlayer);  
        return raycastHit.collider != null;
    }
    private bool onWall()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, new Vector2(transform.localScale.x, 0), 0.1f, wallLayer);
        return raycastHit.collider != null;
    }

    public bool canAttack()
    {
        return movementvalue == 0 && isGrounded() && !onWall();
    }
}
