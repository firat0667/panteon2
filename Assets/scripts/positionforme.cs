using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class positionforme : MonoBehaviour
{
    public float[] racingposition;
    public GameObject playyer;
    public float playerposition;
    public GameObject[] aı;
    public int currentposition;
    public int currentpoint;
    public Text postext;

 

    public float aidistance;
    public float playerdistance;
    public GameObject[] points;
      
   
    void Start()
    {
        racingposition[0] = playyer.GetComponent<playercontroller>().playerdistance;
        racingposition[1] = aı[0].GetComponent<aıcontroller>().aidistance;
        racingposition[2] = aı[1].GetComponent<aıcontroller>().aidistance;

        playerposition = playyer.GetComponent<playercontroller>().playerdistance;
    }
    

    
    void Update()
    {


        calc();

        postext.text = currentposition.ToString() + "/" + racingposition.Length;

      
      
        


    }
    public void calc()
    {
       
        Array.Sort(racingposition);

        int x = Array.IndexOf(racingposition, playerposition);
        switch (x)
        {
            case 0:

                currentposition = 1;
                break;
            case 1:
                currentposition = 2;
                break;
            case 2: 
                currentposition = 3;
                break;
        }



    }
}
