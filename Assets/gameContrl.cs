using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameContrl : MonoBehaviour
{
    public playerCtrl player;
    public float resetTime = 10f;
    public static int constr = 10;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (constr > 1)
        {
            if (player.holdBall == false)
            {
                resetTime -= Time.deltaTime;
                if (resetTime <= 0)
                {
                    SceneManager.LoadScene("Tracky");//Eğer olurda 10f süresinde yarış çizgisine varmasa yeniden başlat
                    constr--;//10 hakkı var 
                }
            }
        }
    }
}
