using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideBoundary : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            this.transform.position = new Vector2(transform.position.x, Player.transform.position.y);
    }
}
