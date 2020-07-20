using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinSpawner : MonoBehaviour
{
    float timer;
    public GameObject coinPrefab;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1.3f && SceneManager.GetActiveScene().name == "Scene1")
        {
            timer = 0;
            float x = Random.Range(-8f, 8f);
            float y = Random.Range(-3f, 0.8f);
            Vector3 position = new Vector3(x, y, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(coinPrefab, position, rotation);
        }
        if (timer >= 1f && (SceneManager.GetActiveScene().name == "Scene2" || SceneManager.GetActiveScene().name == "2P"))
        {
            timer = 0;
            float x = Random.Range(-8f, 8f);
            float y = Random.Range(-3f, 1.3f);
            Vector3 position = new Vector3(x, y, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(coinPrefab, position, rotation);
        }
        if (timer >= 0.7f && SceneManager.GetActiveScene().name == "Scene3")
        {
            timer = 0;
            float x = Random.Range(-8f, 8f);
            float y = Random.Range(-3f, 2.8f);
            Vector3 position = new Vector3(x, y, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(coinPrefab, position, rotation);
        }
    }

    
}
