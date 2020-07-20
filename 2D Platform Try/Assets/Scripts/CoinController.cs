using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinController : MonoBehaviour
{
    float timer;
    public ScoreManager scoreManager;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2f && SceneManager.GetActiveScene().name == "Scene1")
        {
            Destroy(transform.parent.gameObject);
            timer = 0f;
        }
        if (timer >= 1.75f && SceneManager.GetActiveScene().name == "Scene2")
        {
            Destroy(transform.parent.gameObject);
            timer = 0f;
        }
        if (timer >= 2f && SceneManager.GetActiveScene().name == "2P")
        {
            Destroy(transform.parent.gameObject);
            timer = 0f;
        }
        if (timer >= 1.5f && SceneManager.GetActiveScene().name == "Scene3")
        {
            Destroy(transform.parent.gameObject);
            timer = 0f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (SceneManager.GetActiveScene().name == "Scene1" ||
            SceneManager.GetActiveScene().name == "Scene2" ||
            SceneManager.GetActiveScene().name == "Scene3")
        {
            ScoreManager.scoreManager.RaiseScore(1);
        }
        else if (SceneManager.GetActiveScene().name == "2P")
        {
            if (collision.transform.tag == "player")
            {
                ScoreManager.scoreManager.RaiseScore2(1, 0);
            }
            if (collision.transform.tag == "player2")
            {
                ScoreManager.scoreManager.RaiseScore2(0, 1);
            }
        }
        

        Destroy(transform.parent.gameObject);
        SoundManager.PlaySound("CoinSound");
    }
}
