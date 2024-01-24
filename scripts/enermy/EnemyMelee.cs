
using UnityEngine;

public class EnemyMelee : MonoBehaviour
{
    [Header("Attack Parameters")]
    [SerializeField] private float attackCoolDown;
    [SerializeField] private float range;
    [SerializeField] private float damge;

    [Header("Collider Parameters")]
    [SerializeField] private float colliderDistance;
    [SerializeField] private BoxCollider2D boxCollider;

    [Header("Player Layer")]
    [SerializeField] private LayerMask playerLayer;
    private float coolDownTimer = Mathf.Infinity;

    [Header("SoundManager")]
    [SerializeField] private AudioClip meleeSound;

    private Animator anim; 
    private health playerHeath;
    private Patrolling enemyPatrolling;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        enemyPatrolling = GetComponentInParent<Patrolling>();
    }
    private void Update()
    {
        coolDownTimer += Time.deltaTime;

        if (PlayerInside())
        {
            if (coolDownTimer >= attackCoolDown)
            {
                coolDownTimer = 0;
                anim.SetTrigger("meleeAttack");
                Audio.instance.PlaySound(meleeSound);
            }
        }
        if (enemyPatrolling != null)
            enemyPatrolling.enabled = !PlayerInside();
            
    }

    private bool PlayerInside()
    {
        RaycastHit2D hit = Physics2D.BoxCast(boxCollider.bounds.center + transform.right*range*transform.localScale.x*colliderDistance,
             new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y, boxCollider.bounds.size.z),0, Vector2.left, 0, playerLayer);
        if (hit.collider != null)
        {
            playerHeath = hit.transform.GetComponent<health>();
        }

        return hit.collider != null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(boxCollider.bounds.center + transform.right*range*transform.localScale.x*colliderDistance, new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y, boxCollider.bounds.size.z));
    }

    private void DamagePlayer()
    {
        if (PlayerInside())
        {
            playerHeath.TakeDamage(damge);
        }
    }

}
