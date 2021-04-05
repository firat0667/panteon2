using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject targetCamera;
    public Vector3 cameraoffset;
    public Vector3 cameraoffset2;
    public GameObject rotationcam;
   
    float x;
    float y;
    public GameObject user;
    public GameObject finiscube;
    public GameObject paintwall;

    private void Start()
    {


    }
    
    
      

       
    

        
    
    private void LateUpdate()
    {
        x = user.transform.position.z;
        y = finiscube.transform.position.z;
        if (x + 2f > y)
        {
            Debug.Log("bitiyor");
            paintwall.gameObject.SetActive(true);

            transform.position = paintwall.transform.position + cameraoffset2;
           
            

        }
        else if(x + 2f < y)
        {
            transform.position = targetCamera.transform.position + cameraoffset;
        }
        
    }
}
