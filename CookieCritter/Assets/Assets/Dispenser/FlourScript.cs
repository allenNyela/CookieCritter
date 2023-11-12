using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void flourScriptFunction()
    {  
        GameManager.flourClicked = true;
        Destroy(gameObject);
    }
}
