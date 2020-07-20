using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform player;
    public GameObject sword;
    public GameObject shield;
    private bool selSword;
    private bool selShield;
    private Vector3 pos;

    private void Start()
    {
        selSword = false;
        selShield = false;
    }

    private void Update()
    {
        pos = player.position;
        if (selSword)
        {
            transform.position = new Vector3(pos.x + 0.5f, pos.y - 0.5f, 0);
        }
        if (selShield)
        {
            transform.position = new Vector3(pos.x, pos.y - 0.5f, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (gameObject.tag == "Sword")
            {
                Destroy(shield);
                selSword = true;
                transform.Rotate(180, 0, 0);
            }
            if (gameObject.tag == "Shield")
            {
                Destroy(sword);
                selShield = true;
                transform.Rotate(66, 0, 0);
            }
        }
    }
}
