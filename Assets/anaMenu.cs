using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class anaMenu : MonoBehaviour
{
   public void basla()
    {
        SceneManager.LoadScene("Tracky");//start butonuna tıklanınca başlasın oyun

    }
    public void ExittoGame()
    {
        Application.Quit();
    }
}
