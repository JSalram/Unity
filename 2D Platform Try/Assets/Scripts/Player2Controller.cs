using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    bool canJump;
    void Update()
    {
        if (Input.GetKey("j"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-800f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey("l"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(800f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (!(Input.GetKey("l"))&& !(Input.GetKey("j")))
        {
            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }

        if ((Input.GetKeyDown("i")) && canJump)
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
