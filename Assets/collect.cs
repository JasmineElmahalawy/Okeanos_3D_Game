using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float timer = 30f;
    public int score = 0;
    public int requiredScore = 5;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI resultText;
    public GameObject monster;
    public GameObject me;
    //public AudioSource collectionSound;

    private bool gameEnded = false;

    void Start()
    {
        UpdateTimerText();
        UpdateScoreText();
        resultText.text = "";
        if (monster != null)
        {
            monster.SetActive(false);
        }
    }

    void Update()
    {
        if (!gameEnded)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                timer = 0;
                EndGame(false);
            }
            UpdateTimerText();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("target"))
        {
            score++;
            UpdateScoreText();
            //collectionSound.Play();
            Destroy(other.gameObject);

            if (score >= requiredScore)
            {
                EndGame(true);
            }
        }
    }

    void EndGame(bool win)
    {
        gameEnded = true;
        if (win)
        {
            resultText.text = "You Win!";
            if (monster != null)
            {
                monster.SetActive(true);
                me.SetActive(false);
            }
        }
        else
        {
            resultText.text = "You Lose!";
            Invoke("RestartScene", 2f);
        }
    }

    void UpdateTimerText()
    {
        timerText.text = "Time: " + Mathf.Ceil(timer).ToString();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
