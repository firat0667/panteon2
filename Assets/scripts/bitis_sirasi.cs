using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class bitis_sirasi : MonoBehaviour
{

    public Text sira;
    float sirasayisi=5;
   

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("bott"))
        {

            sirasayisi -= 1;
           
        }
    }
    private void Start()
    {
      
    }
    private void Update()
    {
        sira.text = sirasayisi.ToString();
        if (sirasayisi == 0)
        {
            SceneManager.LoadScene(3);
        }
    }
  
}
