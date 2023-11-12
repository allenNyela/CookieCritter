using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject Player;
    public GameObject GameOverScreen;

    // Start is called before the first frame update
    void Awake()
    {
        GameManager.ResetCurrentScore();
        GameOverScreen.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Player.gameObject.GetComponent<Rigidbody2D>().velocity.y >= 0)
        {
            this.transform.position = new Vector2(Player.transform.position.x, Player.transform.position.y - 40);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.StartsWith("Player"))
        {
            GameManager.AddToOverallScore(GameManager.GetCurrentScore());
            GameOverScreen.SetActive(true);
        }
    }
}