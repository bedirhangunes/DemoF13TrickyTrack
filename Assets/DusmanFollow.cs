using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class DusmanFollow : MonoBehaviour
{
    NavMeshAgent aget;
    public GameObject hedeff;
    public GameObject patlamaa;
    void Start()
    {
        aget = GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
        aget.SetDestination(hedeff.transform.position);
    }
     void OnTriggerEnter(Collider col)
    {
        if (col.tag != "buum")
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
            Instantiate(patlamaa,transform.position,transform.rotation);
        }
    }
}
