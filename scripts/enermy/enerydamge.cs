
using System.Net.Security;
using UnityEngine;

public class enerydamge : MonoBehaviour
{
    [SerializeField] protected private float damage;

    protected private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<health>().TakeDamage(damage);
        }
    }

}
