using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class couldıown : MonoBehaviour
{
    IEnumerator startdelay()

    {
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 5f;
        while (Time.realtimeSinceStartup < pauseTime)
        {
            yield return 0;
            countdowntext.gameObject.SetActive(false);
            Time.timeScale = 1;
        }

       
    }
    IEnumerator counttime()
    {

        yield return new WaitForSeconds(1f);
    }
    // Start is called before the first frame update
    float currenttime = 0f;
    float startingtime = 5f;

   public  Text countdowntext;
    private void Start()
    {
        StartCoroutine(startdelay());
        currenttime = startingtime;
    }
    private void Update()
    {
        currenttime -= 1 * Time.deltaTime;
        countdowntext.text = currenttime.ToString("0");

        if (currenttime < 1f)
        {
            countdowntext.text = currenttime.ToString("RUN!");
            StartCoroutine(counttime());
            countdowntext.gameObject.SetActive(false);

           
          
           
        }
    }
 



}
