using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KERORSWERVE : MonoBehaviour
{

    public GameObject userSwerve;
    public GameObject userKeyboard;
    public GameObject camm;
    public GameObject camm2;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetMouseButton(0))
        {
         
         camm2.gameObject.SetActive(true);
          userSwerve.gameObject.SetActive(true);
          userKeyboard.gameObject.SetActive(false);
          camm.gameObject.SetActive(false);

        }
        else if (Input.GetKey(KeyCode.W))
        {
            camm2.gameObject.SetActive(false);
            userSwerve.gameObject.SetActive(false);
            userKeyboard.gameObject.SetActive(true);
            camm.gameObject.SetActive(true);
        }
    }
    IEnumerator waittt()
    {
        userKeyboard.gameObject.SetActive(false);
        userSwerve.gameObject.SetActive(false);
        yield return new WaitForSeconds(5f);
    }
}
