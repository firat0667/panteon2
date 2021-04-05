using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
  
        
  
  
    public void Playgame()
    {
        SceneManager.LoadScene(1);
    }
   public void quitgame()
    {
        Debug.Log("oyundan cıktı");
        Application.Quit();

    }
  public void mainnmenu()
    {
        SceneManager.LoadScene(0);
    }
    public void gameinfoo()
    {
        SceneManager.LoadScene(4);
    }
}
