using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atilacakTop : MonoBehaviour
{
  
    void Start()
    {
        player2 ply = GameObject.FindGameObjectWithTag("Player").GetComponent<player2>();
        GetComponent<Rigidbody>().AddForce(ply.hedefeGit() * 1000);//atış hızı
        transform.rotation = Quaternion.LookRotation(ply.hedefeGit());//belirlenen hedefe gitsin
        Destroy(gameObject, 1);
    
    }

  
    void Update()
    {
        transform.Rotate(0f, 5f, 5f);
    }
  
}
