using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyorswerve : MonoBehaviour
{

    public GameObject halfdonut;
    public GameObject halfdonut2;
    public GameObject userSwerve;
    public GameObject userKeyboard;
    public GameObject camm;
    public GameObject camm2;
    public void swervee()
    {
        camm2.gameObject.SetActive(true);
        userSwerve.gameObject.SetActive(true);
        userKeyboard.gameObject.SetActive(false);
        camm.gameObject.SetActive(false);
        halfdonut.gameObject.SetActive(true);
        halfdonut2.gameObject.SetActive(true);
    }
    public void keyboard()
    {

        halfdonut.gameObject.SetActive(false);
        halfdonut2.gameObject.SetActive(false);
        camm2.gameObject.SetActive(false);
        userSwerve.gameObject.SetActive(false);
        userKeyboard.gameObject.SetActive(true);
        camm.gameObject.SetActive(true);
    }
}
