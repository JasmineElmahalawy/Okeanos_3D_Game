using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition1 : MonoBehaviour
{
   void OnTriggerEnter(Collider co)
    {
        if (co.CompareTag("Door1"))
            SceneManager.LoadScene("trial room");
    }
}
