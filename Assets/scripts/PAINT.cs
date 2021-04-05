using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAİNT3D : MonoBehaviour
{
    public GameObject brush;
    public float brushsize = 0.1f;
    // Start is called before the first frame update
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
