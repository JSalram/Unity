using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoreManager;

    public Text scoreText;
    public Text scoreText2;
    public Text counter;

    int score = 0, score2 = 0;
    float timer;

    private void Start()
    {
        scoreManager = this;
        if (SceneManager.GetActiveScene().name == "Scene1" || SceneManager.GetActiveScene().name == "Scene2")
        {
            timer = 31f;
        }
        else if (SceneManager.GetActiveScene().name == "Scene3")
        {
            timer = 26f;
        }
        else
        {
            timer = 0f;
        }
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "2P")
        {
            timer += Time.deltaTime;
            Counter((int)timer);
        }
        else
        {
            timer -= Time.deltaTime;
            Counter((int)timer);
        }
    }

    public void RaiseScore (int s)
    {
        score += s;
        scoreText.text = "x " + score;

        if (score >= 20 && SceneManager.GetActiveScene().name == "Scene1")
        {
            SceneManager.LoadScene("Scene2");
        }
        if (score >= 25 && SceneManager.GetActiveScene().name == "Scene2")
        {
            SceneManager.LoadScene("Scene3");
        }
        if (score >= 30 && SceneManager.GetActiveScene().name == "Scene3")
        {
            SceneManager.LoadScene("End");
        }
        if (score >= 50 && SceneManager.GetActiveScene().name == "2P")
        {
            SceneManager.LoadScene("End");
        }
    }

    public void RaiseScore2 (int s, int s2)
    {
        score += s;
        scoreText.text = "P1: " + score;
        score2 += s2;
        scoreText2.text = "P2: " + score2;

        if (score >= 30)
        {
            Debug.Log("PLAYER 1 WINS");
            SceneManager.LoadScene("End");
        }
        if (score2 >= 30)
        {
            Debug.Log("PLAYER 2 WINS");
            SceneManager.LoadScene("End");
        }
    }

    public void Counter(int time)
    {
        counter.text = "Tiempo: " + time;

        if (SceneManager.GetActiveScene().name != "2P" && time <= 0f)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
