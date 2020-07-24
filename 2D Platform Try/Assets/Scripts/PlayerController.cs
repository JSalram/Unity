using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool canJump;
    void Update()
    {
        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-800f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(800f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (!(Input.GetKey("right") || Input.GetKey("d")) && !(Input.GetKey("left") || Input.GetKey("a")))
        {
            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }

        if ((Input.GetKeyDown("up") || Input.GetKeyDown("w") || Input.GetKeyDown("space")) && canJump)
        {
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 210f));
            SoundManager.PlaySound("jump");
        }
        JumpAnimator();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ground" || collision.transform.tag == "platform" || collision.transform.tag == "player")
        {
            canJump = true;
        }
    }

    void JumpAnimator()
    {
        if (canJump)
        {
            gameObject.GetComponent<Animator>().SetBool("jumping", false);
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("jumping", true);
        }
    }
}
