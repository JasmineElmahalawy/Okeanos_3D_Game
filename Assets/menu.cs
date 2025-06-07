using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    public void startGame()
    {
        SceneManager.LoadScene("trial with garbage");
    }

    public void quitGame()
    {
        Application.Quit();
    }

}
