using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlManager : MonoBehaviour
{
    float timer;

    void Update()
    {
        timer += Time.deltaTime;
        ExitScene();
    }
    public void ExitScene ()
    {
        if (SceneManager.GetActiveScene().name == "End" && timer > 8)
        {
                SceneManager.LoadScene("Menu");
        }
        if (SceneManager.GetActiveScene().name == "GameOver" && timer > 6)
        {
                SceneManager.LoadScene("Menu");
        }
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene("Menu");
        }
        if (Input.GetKey("0"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
