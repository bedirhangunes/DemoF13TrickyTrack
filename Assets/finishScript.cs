using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class finishScript : MonoBehaviour
{
   
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider col)
    {
        if (col.tag != "finish")
        {
            SceneManager.LoadScene("level2");
        }   
    }
}
