
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
 
    private Transform currentCheckpoint;
    private health playerHealth;

    private void Awake()
    {
        playerHealth = GetComponent<health>();
    }

    public void respawn()
    {
        playerHealth.Respawn(); //Restore player health and reset animation
        transform.position = currentCheckpoint.position; //Move player to checkpoint location

        //Move the camera to the checkpoint's room
        Camera.main.GetComponent<camera>().MoveToNewRoom(currentCheckpoint.parent);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "checkpoint")
        {
            currentCheckpoint = collision.transform;
            collision.GetComponent<Collider2D>().enabled = false;
            collision.GetComponent<Animator>().SetTrigger("appear");

        }
    }
}