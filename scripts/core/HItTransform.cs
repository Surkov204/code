
using UnityEngine;

public class HItTransform : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            TransformScene.instance.Transform();
        }
    }
}
