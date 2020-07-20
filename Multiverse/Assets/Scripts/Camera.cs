
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera : MonoBehaviour
{
    private Vector3 pos;
    public GameObject player;
    void Start()
    {
    }

    void Update()
    {
        if (player.GetComponent<Transform>().position.y < -5)
        {
            transform.position = new Vector3(0, -10, -10);
            if (player.GetComponent<Transform>().position.x > 9)
            {
                SceneManager.LoadScene("Platform");
            }
        }
        else
        {
            transform.position = new Vector3(0, 0, -10);
        }
    }
}
