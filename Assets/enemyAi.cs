using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemyAi : MonoBehaviour
{
    public Transform nisann;
    public Rigidbody atilacakTop;
    NavMeshAgent agent;
    public GameObject hedef;
    bool atesContr = false;
    RaycastHit hit;
    float atisZaman = 0;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }

    void Update()
    {
       
         agent.SetDestination(hedef.transform.position);//hedefe git
        agent.updatePosition = true;
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        rayCizdir();
        if (Input.GetMouseButton(0))
        {
            atisZaman += Time.deltaTime;
            if (atisZaman > 0.6f)
            {

                var stone = Instantiate(atilacakTop, GameObject.Find("enemyTop").transform.position, Quaternion.identity);//toptan atış yap,ileriye doğru
                stone.AddForce(transform.forward * 2000);//atış hızı
                atisZaman = 0;
            }
            atesContr = true;
        }
    }
    void rayCizdir()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if(Physics.Raycast(ray,out hit))
        {

        }
        else
        {

        }
        Debug.DrawRay(ray.origin, ray.GetPoint(1000));
        Debug.DrawLine(hedef.transform.position,hit.point, Color.green);
        
    }
}
