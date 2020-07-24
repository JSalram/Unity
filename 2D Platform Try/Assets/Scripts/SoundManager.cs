using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip coinSound, jump;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        coinSound = Resources.Load<AudioClip>("CoinSound");
        jump = Resources.Load<AudioClip>("jump");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "CoinSound":
                audioSrc.PlayOneShot(coinSound);
                break;
            case "jump":
                audioSrc.PlayOneShot(jump);
                break;
            default:
                break;
        }
    }
}

