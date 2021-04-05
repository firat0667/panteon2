using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QUİT : MonoBehaviour
{
    IEnumerator quit()
    {
       
      
        yield return new WaitForSeconds(4);


        Application.Quit();


    }
    void Start()
    {
        
    }

    // Update is called once per frame
  public void quitt()
    {
       
        SceneManager.LoadScene(0);
        StartCoroutine(quit());
      
        Debug.Log("oyundan cıkıyoruz");
        
        StartCoroutine(quit());

    }
}
