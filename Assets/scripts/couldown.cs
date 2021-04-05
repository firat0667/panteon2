using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class couldown : MonoBehaviour
{
    public int countdown;
    public Text countdownDisplay;
    public GameObject girl;
    public GameObject girl2;
    public GameObject girl3;
    public GameObject girl4;
    public GameObject girl5;
    public GameObject girl6;
    public GameObject girl7;
    public GameObject girl8;
    public GameObject girl9;
    public GameObject girl10;
    public GameObject boyy;

    
    private void Start()
    {
        StartCoroutine(countdownstart());
    }

    IEnumerator countdownstart()
    {
       
        while (countdown > 0)
        {
            // time scale olarak yapmayı denedim olmadı;
            girl.SetActive(false);
            girl2.SetActive(false);
            girl3.SetActive(false);
            girl4.SetActive(false);
            girl5.SetActive(false);
            girl6.SetActive(false);
            girl7.SetActive(false);
            girl8.SetActive(false);
            girl9.SetActive(false);
            girl10.SetActive(false);
            boyy.SetActive(false);


            countdownDisplay.text = countdown.ToString();
            countdown -= 1;
            

            yield return new WaitForSeconds(1f);
           
            
            
            if (countdown == 0)
            {
                girl.SetActive(true);
                girl2.SetActive(true);
                girl3.SetActive(true);
                girl4.SetActive(true);
                girl5.SetActive(true);
                girl6.SetActive(true);
                girl7.SetActive(true);
                girl8.SetActive(true);
                girl9.SetActive(true);
                girl10.SetActive(true);
                boyy.SetActive(true);



                countdownDisplay.text = "RUNN !!";
             
                yield return new WaitForSeconds(1f);
                countdownDisplay.gameObject.SetActive(false);
            }
        }
       
       
       
    }

   
}
