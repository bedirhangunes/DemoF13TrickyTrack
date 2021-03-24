using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScrip : MonoBehaviour
{
    public Text scoreText;
    public static int score = 0;
    public GameObject patlama;

    void Start()
    {
        scoreText.text = "SCORE: " + score;
    }

     void OnTriggerEnter(Collider col)
    {
        if (col.tag != "bomb")
        {
            score = score + 5;//her hedefe atışta 5 puan
            Destroy(gameObject);
            Destroy(col.gameObject);//ve yok olsun
            Instantiate(patlama, transform.position, transform.rotation);

        }
    }
    void Update()
    {
        scoreText.text = "SCORE: " + score.ToString();//scoru  yazdır
    }
}
