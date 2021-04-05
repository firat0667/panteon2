using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showhidestatic : MonoBehaviour
{
    public GameObject HideandshoW;
   IEnumerator hideandshow()
    {
      
        yield return new WaitForSeconds(2);
       
    }
    void Start()
    {
        HideandshoW.SetActive(false);
        StartCoroutine(hideandshow());
        HideandshoW.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
