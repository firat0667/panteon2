using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnett2 : MonoBehaviour
{
    public GameObject magnet;
   public  GameObject enemy;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;
    public GameObject enemy7;
    public GameObject enemy8;
    public GameObject enemy9;
    public GameObject enemy10;

    public GameObject playerr;
    public GameObject playerr2;
    public float distance;
    public float distance2;
    public float distance3;
    public float distance4;
    public float distance5;
    public float distance6;
    public float distance7;
    public float distance8;
    public float distance9;
    public float distance10;
    public float distance11;
    public float distance12;
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("bott");
    }

    
    void Update()
    {
        distance = Vector3.Distance(transform.position, enemy.transform.position);
        distance2 = Vector3.Distance(transform.position, playerr.transform.position);
        distance3 = Vector3.Distance(transform.position, playerr2.transform.position);
        distance4 = Vector3.Distance(transform.position, enemy2.transform.position);
        distance5 = Vector3.Distance(transform.position, enemy3.transform.position);
        distance6 = Vector3.Distance(transform.position, enemy4.transform.position);
        distance7 = Vector3.Distance(transform.position, enemy5.transform.position);
        distance8 = Vector3.Distance(transform.position, enemy6.transform.position);
        distance9 = Vector3.Distance(transform.position, enemy7.transform.position);
        distance10= Vector3.Distance(transform.position, enemy8.transform.position);
        distance11 = Vector3.Distance(transform.position, enemy9.transform.position);
        distance12 = Vector3.Distance(transform.position, enemy10.transform.position);


        if (distance < 12)
        {
            enemy.GetComponent<Rigidbody>().AddForce(Vector3.left * 500f);
        }
        else if (distance2 < 12)
        {
            playerr.GetComponent<Rigidbody>().AddForce(Vector3.left * 500f);
        }
        else if (distance3 < 12)
        {
            playerr2.GetComponent<Rigidbody>().AddForce(Vector3.left * 500f);
        }

        else if(distance4 < 12)
        {
            enemy2.GetComponent<Rigidbody>().AddForce(Vector3.left * 500f);
        }
        else if (distance5 < 12)
        {
            enemy3.GetComponent<Rigidbody>().AddForce(Vector3.left * 500f);
        }
        else if (distance6 < 12)
        {
            enemy4.GetComponent<Rigidbody>().AddForce(Vector3.left * 500f);
        }
        else if (distance7 < 12)
        {
            enemy5.GetComponent<Rigidbody>().AddForce(Vector3.left * 500f);
        }
        else if (distance8 < 12)
        {
            enemy6.GetComponent<Rigidbody>().AddForce(Vector3.left * 500f);
        }
        else if (distance9 < 12)
        {
            enemy7.GetComponent<Rigidbody>().AddForce(Vector3.left * 500f);
        }
        else if (distance10< 12)
        {
            enemy8.GetComponent<Rigidbody>().AddForce(Vector3.left * 500f);
        }
        else if (distance11 < 12)
        {
            enemy9.GetComponent<Rigidbody>().AddForce(Vector3.left * 500f);
        }
        else if (distance12 < 12)
        {
            enemy10.GetComponent<Rigidbody>().AddForce(Vector3.left * 500f);
        }
    }
}
