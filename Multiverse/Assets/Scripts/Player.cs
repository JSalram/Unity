using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name.Equals("MainScene"))
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
            {
                rb.AddForce(new Vector2(0, speed * Time.deltaTime));
            }
            else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
            {
                rb.AddForce(new Vector2(0, -speed * Time.deltaTime));
            }

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
            {
                rb.AddForce(new Vector2(speed * Time.deltaTime, 0));
            }
            else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
            {
                rb.AddForce(new Vector2(-speed * Time.deltaTime, 0));
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
            {
                rb.AddForce(new Vector2(speed * Time.deltaTime, 0));
            }
            else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
            {
                rb.AddForce(new Vector2(-speed * Time.deltaTime, 0));
            }

            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector2(0, speed * 50 * Time.deltaTime));
            }
        }
    }
}
