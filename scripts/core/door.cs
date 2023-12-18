using UnityEngine;

public class door : MonoBehaviour
{
    [SerializeField] private Transform previousRoom;
    [SerializeField] private Transform nextRoom;
    [SerializeField] private camera cam;

    private void Awake()
    {
        cam = Camera.main.GetComponent<camera>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.transform.position.x < transform.position.x)
            {
                cam.MoveToNewRoom(nextRoom);
               
            } 
            else
            {
                cam.MoveToNewRoom(previousRoom);
              
            }
                
        
        }
    }
}