using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class position6Up : MonoBehaviour
{
    public GameObject posDisplay;
    // Start is called before the first frame update
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "position")
        {
            posDisplay.GetComponent<Text>().text = "6th";
        }
    }
}
