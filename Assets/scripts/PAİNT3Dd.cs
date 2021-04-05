using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PAİNT3Dd : MonoBehaviour
{
    public GameObject brush;
    public float brushsize = 0.1f;

   

    void Start()
    {
   
}

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(Ray, out hit))
            {
                var paint = Instantiate(brush, hit.point + Vector3.up * 0.1f, Quaternion.identity, transform);
                paint.transform.localScale = Vector3.one * brushsize;
            }
        }
    }
}
