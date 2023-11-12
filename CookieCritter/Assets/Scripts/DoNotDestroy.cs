using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour
{
    public GameObject backgroundMusic;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(backgroundMusic);
    }

}
