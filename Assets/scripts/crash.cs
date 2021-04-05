using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crash : MonoBehaviour
{
    public GameObject user;
    public GameObject crashing;
    public GameObject user2;





    void OnCollisionEnter(Collision collision)
    {

        


        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("dokundu");


            user.SetActive(false);

               user.transform.position = new Vector3(0, 0, -52);
            user.SetActive(true);
          

        }

        if (collision.gameObject.tag.Equals("Player2"))
        {
            user2.SetActive(false);

            user2.transform.position = new Vector3(0, 0, -52);
            user2.SetActive(true);
        }
              





    }

}
