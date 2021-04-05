using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float playerdistance;
    public GameObject[] points;
    public positionforme master;
    
    

    // Update is called once per frame
    void Update()
    {
        playerdistance = Vector3.Distance(points[master.currentpoint].transform.position, this.transform.position);
    }
}
