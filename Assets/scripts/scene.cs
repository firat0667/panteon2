using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    IEnumerator scene2()
    {
        
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(1);
    }
    private void Update()
    {
        StartCoroutine(scene2());
    }
}
