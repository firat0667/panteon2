using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Serialization;

public class swerve : MonoBehaviour
{
    private movement swerveinputsystem;
    [SerializeField] private float swervespeed = 5f;
    [SerializeField] private float lerpspeed = 5f;
    [SerializeField] private float playerxvalue= 2f;
    [SerializeField] Vector2 clampvalue = new Vector2(-2, 2);

    private Rigidbody rb;
    private float newxpos;
    private float startxpos;
  
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
       startxpos = transform.position.x;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Horizontal"))
        {
            newxpos = Mathf.Clamp( transform.position.x + Input.GetAxisRaw("Horizontal") * playerxvalue,startxpos+ clampvalue.y,startxpos);

        }
    }
    private void FixedUpdate()
    {
        //player movement 
        rb.MovePosition(new Vector3(Mathf.Lerp(transform.position.x,newxpos,lerpspeed*Time.fixedDeltaTime), rb.velocity.y, transform.position.z + swervespeed * Time.deltaTime));
    }
}
