using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject Player;
    public GameObject GameOverScreen;
    public GameObject PausedScreen;

    // Start is called before the first frame update
    void Awake()
    {
        GameManager.ResetCurrentScore();
        GameOverScreen.SetActive(false);
        PausedScreen.SetActive(false);
        Cursor.visible = false;
        Player.GetComponent<SpriteRenderer>().sprite = GameManager.Player;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Player.gameObject.GetComponent<Rigidbody2D>().velocity.y >= 0)
        {
            this.transform.position = new Vector2(Player.transform.position.x, Player.transform.position.y - 30);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.StartsWith("Player"))
        {
            float score = GameManager.GetCurrentScore();
            //Debug.Log(score);
            GameManager.AddToOverallScore(score);
            //Debug.Log(GameManager.GetOverallScore());
            GameOverScreen.SetActive(true);
            Cursor.visible = true;
            Destroy(this);
        }
    }
}
