using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class denemeucma : MonoBehaviour
{
    public GameObject bod;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bod.transform.position.y <= -35)
        {

            bod.SetActive(false);
            Debug.Log("dusuom ama olmuor");
            bod.transform.position = new Vector3( 0, 0, -47f);
            bod.SetActive(true);

        }
    }
}
