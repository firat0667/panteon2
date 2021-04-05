using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tryAgain : MonoBehaviour
{
    public GameObject user;
   

    
    // Start is called before the first frame update
    void Start()
    {

        user = GameObject.FindWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
       if(user.transform.position.y  <= - 10f)
        {
            Debug.Log("düişüor ama neden respawn olmuor anlamadım");
            user.transform.position = new Vector3(0f, 0.3f, -28f);
        }
    }
}
