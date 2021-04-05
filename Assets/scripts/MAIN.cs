using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MAIN : MonoBehaviour
{
   


    public void quit()
    {
        StartCoroutine(waitt());
        Application.Quit();
    }
    public void tryagain()
    {
        SceneManager.LoadScene(1);
    }
   
    IEnumerator waitt()
    {
        SceneManager.LoadScene(2);
        yield return new WaitForSeconds(3);
    }
}
