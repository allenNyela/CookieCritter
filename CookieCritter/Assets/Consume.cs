using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Consume : MonoBehaviour
{
    public GameObject Sprinkle;
    // Start is called before the first frame update
    void Start()
    {
        
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
            Instantiate(Sprinkle, new Vector2(Random.Range(-10.5f, 10.5f), collision.transform.position.y + (15 + Random.Range(0.2f, 1.0f))), Quaternion.identity);
            Destroy(gameObject);

        }
    }
}
