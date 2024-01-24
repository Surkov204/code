
using UnityEngine;

public class PlayerCanAttack : MonoBehaviour
{
    [SerializeField] private float attackCoolDown;
    [SerializeField] private Transform firepoint;
    [SerializeField] private GameObject[] fireballs;
    [SerializeField] private AudioClip FireBallSound;
    private Animator anim;
    private PlayerMoverment playerMoverment;
    private float coolDownTimer = Mathf.Infinity;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMoverment = GetComponent<PlayerMoverment>();
    }
    private void Update()
    {
        if (Input.GetMouseButton(0) && coolDownTimer > attackCoolDown && playerMoverment.canAttack())
        {
            attack();    
        }
        coolDownTimer += Time.deltaTime;

    }

    private void attack()
    {
        Audio.instance.PlaySound(FireBallSound);
        anim.SetTrigger("attack");
        coolDownTimer = 0;

        fireballs[FindFireball()].transform.position = firepoint.position;
        fireballs[FindFireball()].GetComponent<projetTile>().SetDirection(Mathf.Sign(transform.localScale.x));
    }
    private int FindFireball()
    {
        for (int i = 0; i< fireballs.Length;i++)
        {
            if (!fireballs[i].activeInHierarchy)
                return i;
        }
        return 0;
    }
}
