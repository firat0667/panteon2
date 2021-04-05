using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class swervescript : MonoBehaviour
{

  



    [SerializeField] private float swervespeed;
    [SerializeField] private bool gameend;
    [SerializeField] private float lerpwalue;

    private float newxpos;
    private Rigidbody rb;
    private Camera cam;
    Animator anim;
    float rotVolue = 80;
    float gravity = 8;
    float rot = 0;
    Vector3 MoveDirection = Vector3.zero;
    public GameObject user;
    public GameObject finiscube;
     float x;
    float y;
    void Start()
    {

        
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = user.transform.position.z;
        y = finiscube.transform.position.z;
        if (x + 2f > y)
        {


            StartCoroutine(victoryidle());







        }
        if (user.transform.position.y <= -35)
        {
           

            Debug.Log("dusuom ama olmuor");
            user.transform.position = new Vector3(0, 0, -52);
           
        }
        rot += Input.GetAxis("Horizontal") * rotVolue * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);
        MoveDirection.y -= gravity * Time.deltaTime;
    }
    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            moveee();

          //  rb.MovePosition(new Vector3(Mathf.Lerp(transform.position.x, newxpos,lerpwalue), rb.velocity.y, transform.position.z + swervespeed * Time.deltaTime));
            rb.velocity = Vector3.forward * swervespeed * Time.deltaTime;
            anim.SetBool("runnn", true);
            anim.SetBool("idlee", false);
            anim.SetBool("jump", false);
             
        }
        else
        {
            anim.SetBool("runnn", false);
            anim.SetBool("idlee", true);
            anim.SetBool("jump", false);
        }
        if (Input.GetMouseButtonDown(1))
        {
            anim.SetBool("jump", true);
            anim.SetBool("runnn", false);
            anim.SetBool("idlee", false);

        }


      
    }
    private void moveee()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit,500))
        {
           rb.transform.position=  Vector3.Lerp (rb.transform.position,new Vector3(hit.point.x,rb.transform.position.y, rb.transform.position.z) ,lerpwalue*Time.deltaTime);
          //  rb.MovePosition(new Vector3(Mathf.Lerp(transform.position.x, newxpos, lerpwalue * Time.fixedDeltaTime), rb.velocity.y, transform.position.z + swervespeed * Time.fixedDeltaTime));
        }
    }
    IEnumerator victoryidle()
    {
        anim.SetBool("runnn", false);
        anim.SetBool("jump", false);
        anim.SetBool("idlee", false);
        anim.SetBool("victory", true);

        yield return new WaitForSeconds(5);
        user.gameObject.SetActive(false);
    }
}
