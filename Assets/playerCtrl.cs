using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playerCtrl : MonoBehaviour
{
    public topp topi;
    public GameObject playerCamera;
    public float ballDisc = 6f;
    public float ballTF = 5f;//topu atma hızı
    public bool holdBall = true;
    AudioSource sorc;
    void Start()
    {
        topi.GetComponent<Rigidbody>().useGravity = false;
        sorc = GetComponent<AudioSource>();
        
    }

  
    void Update()
    {
      
        if (holdBall)
        {//atış kısmı
            topi.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDisc;
            if (Input.GetMouseButtonDown(0))
            {
                holdBall = false;
                topi.ActivateTrail();
                sorc.Play();
                topi.GetComponent<Rigidbody>().useGravity = true;
                topi.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballTF);
            }
        }
    }
     void OnTriggerEnter(Collider col)
    {
        if (col.tag == "water")
        {
            SceneManager.LoadScene("Tracky");//suya düşerse oyunu yeniden başlat
        }
    }

}
