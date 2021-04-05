using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class NAVMESH : MonoBehaviour
{
    private Animator animator;
    public GameObject bott;
    Vector3 MoveDirection = Vector3.zero;
    float speedVolue = 3f;
    public GameObject[] yorunge;
    NavMeshAgent agent;
    public int sıra = 0;
 private float distance;
    public Transform hedef;
    public float mesafe;
    public float mesafe2;
    public float mesafe3;
    public float mesafe4;
    public Transform hedef2;
    public Transform hedef3;
    public Transform hedef4;
    public GameObject user;
    public GameObject user2;
   












    void Start()
    {
        animator=this.GetComponent<Animator>();
        agent = this.GetComponent<NavMeshAgent>();
        animator.SetBool("runnn", true);
        animator.SetBool("idlee", false);
      
    }
    IEnumerator waitbefore()
    {
      
        yield return new WaitForSeconds(1.5f);
      


    }
    IEnumerator waitandlost()
    {

        yield return new WaitForSeconds(5f);
        bott.gameObject.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

       
      



        mesafe = Vector3.Distance(transform.position, hedef.transform.position);
        mesafe2 = Vector3.Distance(transform.position, hedef2.transform.position);
        mesafe3= Vector3.Distance(transform.position, hedef3.transform.position);
        mesafe4 = Vector3.Distance(transform.position, hedef4.transform.position);
       
        if (mesafe >= 5 || transform.position.x.Equals(hedef.transform.position.x))
        {
            agent.destination = yorunge[sıra].transform.position;
            agent.enabled = true;
          
        }
        else if(mesafe<5 &&  transform.position.x != hedef.transform.position.x && transform.position.z < hedef.transform.position.z)
        {
           animator.SetBool("runnn", false);
            agent.enabled = false;
            StartCoroutine(waitbefore());
            agent.enabled = true;
            Debug.Log("1.degmek uzre");
            animator.SetBool("runnn", true);

        }
        if (mesafe2 >= 5 || transform.position.x.Equals(hedef2.transform.position.x))
        {
            agent.destination = yorunge[sıra].transform.position;
            agent.enabled = true;

        }
        else if (mesafe2 < 5 && transform.position.x != hedef2.transform.position.x && transform.position.z<hedef2.transform.position.z)
        {
            animator.SetBool("runnn", false);
            agent.enabled = false;
            StartCoroutine(waitbefore());
            agent.enabled = true;
            Debug.Log("2.degmek uzre");
            animator.SetBool("runnn", true);
        }
        if (mesafe3>= 5 || transform.position.x.Equals(hedef3.transform.position.x))
        {
            agent.destination = yorunge[sıra].transform.position;
            agent.enabled = true;

        }
        else if (mesafe3 < 5 && transform.position.x != hedef3.transform.position.x && transform.position.z < hedef3.transform.position.z)
        {
            animator.SetBool("runnn", false);
            agent.enabled = false;
            StartCoroutine(waitbefore());
            agent.enabled = true;
            Debug.Log("3.degmek uzre");
            animator.SetBool("runnn", true);
        }
        if (mesafe4 >= 5 || transform.position.x.Equals(hedef4.transform.position.x))
        {
            agent.destination = yorunge[sıra].transform.position;
            agent.enabled = true;

        }
        else if (mesafe4 < 5 && transform.position.x != hedef4.transform.position.x && transform.position.z < hedef4.transform.position.z)
        {
            animator.SetBool("runnn", false);
            agent.enabled = false;
            StartCoroutine(waitbefore());
            agent.enabled = true;
            Debug.Log("4.degmek uzre");
            animator.SetBool("runnn", true);
        }



        if (animator.GetCurrentAnimatorStateInfo(0).IsName("runn"))
        {
            MoveDirection = transform.TransformDirection(MoveDirection);
            MoveDirection = new Vector3(0, 0, 1);
            MoveDirection *= speedVolue;
            distance = Vector3.Distance(transform.position, yorunge[sıra].transform.position);
            if (distance < 1)
            {
                sıra++;
            }
            else if(sıra==yorunge.Length)
            {
                sıra = 0;
            }
        }
       /* if (bott.transform.position.z <= 73f)
        {
            MoveDirection = new Vector3(0, 0, 1);
            MoveDirection *= speedVolue;
            animator.SetBool("runnn", true);
            MoveDirection = transform.TransformDirection(MoveDirection);
           
            //  animator.SetBool("jump", false);

        }
       */
        if (bott.transform.position.y <= -35)
        {


           
            bott.transform.position = new Vector3(-7.41f, 7.7f, -46.94f);


        }
       


    }
    void OnCollisionEnter(Collision collision)
    {

      


        if (collision.gameObject.tag.Equals("finish"))
        {
            Debug.Log("bitirdi");
           
            animator.SetBool("runnn", false);
            animator.SetBool("idlee", true);

            StartCoroutine(waitandlost());
            



            

           
            

        }
        if (collision.gameObject.tag.Equals("engel"))
        {
            bott.SetActive(false);
           
            bott.transform.position = new Vector3(2, 0, -52);

            bott.SetActive(true);
            Debug.Log("dokundu");


           

           
         

        }
        if (collision.gameObject.tag.Equals("bott"))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.forward*200f);


        }
        if (collision.gameObject.tag.Equals("Player"))
        {
          



            this.GetComponent<Rigidbody>().AddForce(Vector3.forward * 200f);
            user.GetComponent<Rigidbody>().AddForce(Vector3.back*100f);

        }
        if (collision.gameObject.tag.Equals("Player2"))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.forward * 200f);
            user2.GetComponent<Rigidbody>().AddForce(Vector3.back * 100f);

        }








    }


}

