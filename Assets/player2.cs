using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class player2 : MonoBehaviour
{
    public GameObject nisan, top;
    Vector3 vect;
    RaycastHit hit;
    bool fireCont = false;
    float atisZamani = 1;
    void Start()
    {
        vect = new Vector3();

    }

 
    void Update()
    {
        rayCizdirme();
        if (Input.GetMouseButton(0))
        {
            atisZamani += Time.deltaTime;
            if (atisZamani > 0.5f)//atış sırası,0.5f de bir top at
            {
                Instantiate(top, nisan.transform.position, Quaternion.identity);//top kurşun gibi düşünürsek
                atisZamani = 0;
            }
            fireCont = true;

        }
    }
    void rayCizdirme()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if(Physics.Raycast(ray,out hit))
        {
            Debug.Log("See");
        }
        else
        {
            Debug.Log("Not see");
        }
        Debug.DrawRay(ray.origin, ray.GetPoint(1000));
        Debug.DrawLine(nisan.transform.position, hit.point);

    }
    public Vector3 hedefeGit()
    {
        return (hit.point - nisan.transform.position).normalized;
    }
     void OnTriggerEnter(Collider col)
    {
        if (col.tag == "water")
        {
            SceneManager.LoadScene("level2");
        }
    }
}
