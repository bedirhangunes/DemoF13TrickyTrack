using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    public playerCtrl playr;
    public Text scoreText;
    public Text throwText;
    public float timer = 5f;
    public static int scor;
    public static int throwi = 10;
    public GameObject bomb;
    void Start()
    {
        
    }

     void OnTriggerEnter(Collider col)
    {
        if (col.tag!="boom")
        {
            scor = scor + 10;
           

                Destroy(gameObject);
                Destroy(col.gameObject);
                Instantiate(bomb, transform.position, transform.rotation);
           
          
            
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            throwi = throwi - 1;
            if (throwi == 0)
            {
                SceneManager.LoadScene("Tracky");
            }
        }
        if (throwi <= 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {

            }
        }
        scoreText.text = "SCORE: " + scor.ToString();
        throwText.text = "CAN: " + throwi.ToString();
    }
}
