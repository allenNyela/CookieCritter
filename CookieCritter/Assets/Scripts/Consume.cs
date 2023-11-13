using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consume : MonoBehaviour
{
    public GameObject Sprinkle;
    public Sprite Sprinkle1;
    public Sprite Sprinkle2;
    public Sprite Sprinkle3;
    public Sprite Sprinkle4;
    public Sprite Sprinkle5;
    // Start is called before the first frame update
    void Start()
    {
        int rand = 0;
        rand = Random.Range(1, 5);
        if (rand == 1) {
            gameObject.GetComponent<SpriteRenderer>().sprite = Sprinkle1;
        } else if (rand == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Sprinkle2;
        } else if (rand == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Sprinkle3;
        } else if (rand == 4)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Sprinkle4;
        } else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Sprinkle5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.StartsWith("Player"))
        {
            GameManager.IncreaseScore();
            this.transform.position = new Vector2(Random.Range(-10.5f, 10.5f), collision.transform.position.y + (8 + Random.Range(0.2f, 1.0f)));

        }
    }
}
