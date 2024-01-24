
using System.Collections;
using UnityEditor;
using UnityEngine;

public class health : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;

    [Header("Iframe")]
    [SerializeField] private float iFramesDuration;
    [SerializeField] private float numberOfFlashes;
    private SpriteRenderer spriteRender;

    [Header("component")]
    [SerializeField] private Behaviour[] components;

    [Header("SoundMangager")]
    [SerializeField] private AudioClip SoundHurt;
    [SerializeField] private AudioClip SoundDie;

    private PlayerRespawn playerRespawn;
    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        spriteRender = GetComponent<SpriteRenderer>();
        playerRespawn = GetComponent<PlayerRespawn>();
    }
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            Audio.instance.PlaySound(SoundHurt);
            anim.SetTrigger("hurt");
            StartCoroutine(Invunerability());
        }

       else
        if (!dead)
        {
            Audio.instance.PlaySound(SoundDie);
        
            foreach(Behaviour component in components)
            {
                component.enabled = false;
            }
            anim.SetBool("ground", true);
            anim.SetTrigger("die");
            dead = true;
         
        }

    }
    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }
    private IEnumerator Invunerability ()
    {
        Physics2D.IgnoreLayerCollision(8, 9, true);
        for (int i = 0; i < numberOfFlashes; i++)
        {
            spriteRender.color = new Color(1, 0, 0, 0.5f);
            yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
            spriteRender.color = Color.white;
            yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
        }

        Physics2D.IgnoreLayerCollision(8, 9, false);
    }
    public void Deactivate()
    {
        gameObject.SetActive(false);
    }
    public void Respawn()
    {
        dead = false;
        AddHealth(startingHealth);
        anim.ResetTrigger("die");
        anim.Play("New Animation");
        StartCoroutine(Invunerability());

        //Activate all attached component classes
        foreach (Behaviour component in components)
            component.enabled = true;
    }
}
