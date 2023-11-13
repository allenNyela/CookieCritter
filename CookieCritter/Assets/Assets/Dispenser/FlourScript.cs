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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.name.StartsWith("DoughIdle"))
        //{
            
        //}
    }
}
