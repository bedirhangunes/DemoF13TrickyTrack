using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topp : MonoBehaviour
{
    public GameObject trailEffect;
    void Start()
    {
        trailEffect.SetActive(false);
       
    }

   
   public void ActivateTrail()
    {
        trailEffect.SetActive(true);
    }
     void Update()
    {
        transform.Rotate(0, 5f, 10f);
    }
}
