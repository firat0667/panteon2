using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool isUsed;
    public positionforme master;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="bott" && !isUsed || other.tag=="Player" && !isUsed)
        {
            isUsed = true;
            master.currentposition++;
        }
    }
}
