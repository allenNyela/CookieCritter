using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTitle : MonoBehaviour
{
    public float amplitude;
    public float frequency;
    Vector3 initPos;
    // Start is called before the first frame update
    void Start()
    {
        initPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(initPos.x, Mathf.Sin(Time.time * frequency) * amplitude + initPos.y, 0);
    }
}
