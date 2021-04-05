using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class target : MonoBehaviour
{

    Rigidbody rgb;
    Vector3 velocity;
    float speedVolue = 3f;
    float jumpVolue = 5f;

    float rotVolue = 80;
    float gravity2 = 0;
    float rot = 0;
    private Animator animator;
    public GameObject bott;

    Vector3 MoveDirection = Vector3.zero;
    CharacterController girlcontrol;


    private void Awake()
    {
      
    }
    void Start()
    {
      
        animator = GetComponent<Animator>();
        bott = GameObject.FindWithTag("bott");
    }

    // Update is called once per frame
    void Update()
    {
      
        
       
        
            if (bott.transform.position.z<=73f)
            {
                MoveDirection = new Vector3(0, 0, 1);
                MoveDirection *= speedVolue;
                animator.SetBool("runnn", true);
                MoveDirection = transform.TransformDirection(MoveDirection);
                animator.SetBool("idlee", false);
              //  animator.SetBool("jump", false);

            }
            else
            {
                MoveDirection = new Vector3(0, 0, 0);
                animator.SetBool("runnn", false);
                animator.SetBool("idlee", true);
               //
               //
               //animator.SetBool("jump", false);

            }
         /*   if (bott.transform.position.y>=)
            {

                animator.SetBool("jump", true);
                animator.SetBool("runnn", false);
                animator.SetBool("idlee", false);
            }
         */


        if (bott.transform.position.y <= -35)
        {


            Debug.Log("dusuom ama olmuor");
            bott.transform.position = new Vector3(0, 1.23f, -50);


        }


        // rot += Input.GetAxis("Horizontal") * rotVolue * Time.deltaTime;
       // transform.eulerAngles = new Vector3(0, rot, 0);
        //MoveDirection.y -= gravity2 * Time.deltaTime;

    }
}
