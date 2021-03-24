using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScript : MonoBehaviour
{
  
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider col)
    {
        if (col.tag != "End")
        {
            SceneManager.LoadScene("level3");//eğer alana gelirse diğer svenes e geç 
        }
    }
}
