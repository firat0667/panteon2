using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour

{ Rigidbody rgb;
    Vector3 velocity;
    float speedVolue = 5f;
    float jumpVolue = 5f;
 
    float rotVolue = 80;
    float gravity = 8;
    float rot = 0;
    private Animator animator;
    public GameObject user;
    float x;
    float y;
    public GameObject finiscube;
  


    Vector3 MoveDirection = Vector3.zero;
    CharacterController control;
  
 


    // Start is called before the first frame update
    void Start()
    {
        
        control = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        user = GameObject.FindWithTag("Player");
     
      
    }

    // Update is called once per frame
    void Update()
    {
       




        if (user.transform.position.y <= -35)
        {
            control.gameObject.SetActive(false);
           
            Debug.Log("dusuom ama olmuor");
            user.transform.position = new Vector3(0, 0, -52);
            control.gameObject.SetActive(true);
        }
      
        if (control.isGrounded)
        {
            if (Input.GetKey(KeyCode.W))
            {
                MoveDirection = new Vector3(0, 0, 1);
                MoveDirection *= speedVolue;
                animator.SetBool("runnn", true);
                MoveDirection = transform.TransformDirection(MoveDirection);
                animator.SetBool("idlee", false);
                animator.SetBool("jump", false);

            }
            else
            {
                MoveDirection = new Vector3(0, 0, 0);
                animator.SetBool("runnn", false);
                animator.SetBool("idlee", true);
                animator.SetBool("jump", false);

            }
            if(Input.GetKey(KeyCode.Space))
            {
               
                animator.SetBool("jump", true);
                animator.SetBool("runnn", false);
                animator.SetBool("idlee", false);
            }
            
            
          

        }
        
       
        
        
        rot += Input.GetAxis("Horizontal") * rotVolue * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);
        MoveDirection.y -= gravity * Time.deltaTime;
        control.Move(MoveDirection * Time.deltaTime);


        x = user.transform.position.z;
        y = finiscube.transform.position.z;
        if (x + 2f > y)
        {


            StartCoroutine(victoryidle());


            




        }

    }
    IEnumerator victoryidle()
    {
        animator.SetBool("runnn", false);
        animator.SetBool("jump", false);
        animator.SetBool("idlee", false);
        animator.SetBool("victory", true);

        yield return new WaitForSeconds(5);
        user.gameObject.SetActive(false);
    }

  
    }
 


