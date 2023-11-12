using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Controller : MonoBehaviour
{

    private Rigidbody2D rb;
    private float moveInput;
    [SerializeField]
    private float speed;
    public GameObject PausedScreen;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //speed = 10f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!GameManager.IsPaused())
        {
            PausedScreen.SetActive(false);
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        } else
        {
            PausedScreen.SetActive(true);
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
        }
    }
}
