using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TransformScene : MonoBehaviour
{
    public static TransformScene instance { get; private set; }
    private void Awake()
    {
        instance = this;
    }
    public void Transform()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex+1);
    }
}
  
