using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Platform : MonoBehaviour
{
    float waitTime;
    
    void Start()
    {
        waitTime = 0f;
    }

    void Update()
    {
        waitTime += Time.deltaTime;
        if (SceneManager.GetActiveScene().name != "2P")
        {
            if (Input.GetKeyDown("s") || Input.GetKeyDown("down"))
            {
                GetComponent<PlatformEffector2D>().rotationalOffset = 180f;
                waitTime = 0f;
            }
            if (waitTime >= 0.2f)
            {
                GetComponent<PlatformEffector2D>().rotationalOffset = 0f;
            }
        }
        else
        {
            if (Input.GetKeyDown("s") || Input.GetKeyDown("down") || Input.GetKeyDown("k"))
            {
                GetComponent<PlatformEffector2D>().rotationalOffset = 180f;
                waitTime = 0f;
            }
            if (waitTime >= 0.2f)
            {
                GetComponent<PlatformEffector2D>().rotationalOffset = 0f;
            }
        }
    }
}
