using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    bool right;
    float length = 40;
    float count = 0;
    float deltaTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (Random.Range(1, 2) == 1) {
            right = true;
        } else
        {
            right = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (deltaTime % 3 == 0)
        {
            {

            }
            if (right)
            {
                transform.position = new Vector2(transform.position.x + .2f, transform.position.y);
                count++;
                if (count >= length)
                {
                    right = false;
                }
            }
            else
            {
                transform.position = new Vector2(transform.position.x - .2f, transform.position.y);
                count--;
                if (count <= 0)
                {
                    right = true;
                }
            }
        }
        deltaTime++;
    }
}
