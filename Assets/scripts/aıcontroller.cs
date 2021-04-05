using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aıcontroller : MonoBehaviour
{
    public bool isUsed;
    public positionforme master;
    public float aidistance;
    public GameObject[] points;

  
    private void Update()
    {
       aidistance = Vector3.Distance(points[master.currentpoint].transform.position, this.transform.position);
    }
}
