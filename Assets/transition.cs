using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    void update()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            SceneManager.LoadScene("trial");
        }

    }
    
}