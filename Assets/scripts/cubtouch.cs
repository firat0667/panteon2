using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cubtouch : MonoBehaviour
{

    public GameObject cam;
    public GameObject paintwall;
    public GameObject user;
    public GameObject finiscube;
    public float bitismesafesi;
    float x;
    float y;
    void Start()
    {
        paintwall.gameObject.SetActive(false);
      
        
;    }

    // Update is called once per frame

    private void Update()
    {
        x = user.transform.position.z;
        y = finiscube.transform.position.z;
       
       bitismesafesi = Vector3.Distance(user.transform.position, finiscube.transform.position);
        if (x + 2f >y)
        {
           
            Debug.Log("bitiyor");
            paintwall.gameObject.SetActive(true);

            cam.transform.position = new Vector3(0, 30f, 65f);


            StartCoroutine(waitandlost());

         


        }
    }

    IEnumerator waitandlost()
        {

             
            yield return new WaitForSeconds(5);
        SceneManager.LoadScene(2);
       

    }
    
    }

