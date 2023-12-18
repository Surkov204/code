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

    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    [SerializeField] private LayerMask groundlayer;
    [SerializeField] private LayerMask wallLayer;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        movementvalue = Input.GetAxis("Horizontal");
       
        if (movementvalue > 0.01f)
            transform.localScale = Vector3.one;
        else if (movementvalue < -0.01f)
            transform.localScale = new Vector3(-1, 1, 1);



        anim.SetBool("run", movementvalue != 0);
        anim.SetBool("ground", isGrounded());

        if (wallJumpCooldown > 0.2f)
        {


            body.velocity = new Vector2(movementvalue * speed, body.velocity.y);

            if (onWall() && !isGrounded())
            {
                body.gravityScale = 0;
                body.velocity = Vector2.zero;

            }
            else
                body.gravityScale = 7;

            if (Input.GetKey(KeyCode.Space))
            {
                jump();
            }

        }
        else
            wallJumpCooldown += Time.deltaTime;
           


    }
    private void jump()
    {
        if (isGrounded())
        {
            body.velocity = new Vector2(body.velocity.x, jumpPower);
            anim.SetTrigger("jump");
        } else 
           if (onWall() && !isGrounded())
           {
             if(movementvalue == 0)
             {
                body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 10, 0);
                transform.localScale = new Vector3(-Mathf.Sign(transform.localScale.x), transform.localScale.y, transform.localScale.z);

            } else
                body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 3, 6);
                wallJumpCooldown = 0;
           }

       
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
