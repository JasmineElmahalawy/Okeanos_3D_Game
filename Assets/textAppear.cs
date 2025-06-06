using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textAppear : MonoBehaviour
{

    public TextMeshProUGUI textFile;
    public string txt;
    public ScrollRect scroll;
    //public AudioSource audio;
   // public AudioClip pickSound;
    // Start is called before the first frame update
    void Start()
    {
        textFile.gameObject.SetActive(false);
        scroll.gameObject.SetActive(false);

    }


    void OnCollisionEnter(Collision player)
    {

        if (player.gameObject.tag == "Player")
        {

            textFile.text = txt;
            textFile.gameObject.SetActive(true);
            scroll.gameObject.SetActive(true);
            //sound
           // AudioSource s = audio.GetComponent<AudioSource>();
            //s.PlayOneShot(pickSound);
        }


    }
    void OnCollisionExit(Collision player)
    {
        if (player.gameObject.tag == "Player")
        {
            textFile.gameObject.SetActive(false);
            scroll.gameObject.SetActive(false);

            //AudioSource audd = audio.GetComponent<AudioSource>();
            //audd.Stop();

            //	s.PlayOneShot(pickSound); */
        }

    }

}