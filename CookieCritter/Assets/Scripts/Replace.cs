using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replace : MonoBehaviour
{

    public GameObject Player;
    public GameObject Platform;
    public GameObject ExtraBouncy;
    public GameObject Movy;
    public GameObject myPlat;
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
        int rand = 0;
        if (collision.gameObject.name.StartsWith("Platform"))
        {
            if ((rand = Random.Range(1, 9)) == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(ExtraBouncy, new Vector2(Random.Range(-10.5f, 10.5f), Player.transform.position.y + (8 + Random.Range(0.2f, 1.0f))), Quaternion.identity);
            } else if ((rand = Random.Range(1, 4)) == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(Movy, new Vector2(Random.Range(-7.5f, 7.5f), Player.transform.position.y + (8 + Random.Range(0.2f, 1.0f))), Quaternion.identity);
            }
            else
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-10.5f, 10.5f), Player.transform.position.y + (8 + Random.Range(0.2f, 1.0f)));
            }
        }
        else if (collision.gameObject.name.StartsWith("ExtraBouncy"))
        {
            if ((rand = Random.Range(1, 9)) == 1)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-10.5f, 10.5f), Player.transform.position.y + (8 + Random.Range(0.2f, 1.0f)));
            }
            else if ((rand = Random.Range(1, 4)) == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(Movy, new Vector2(Random.Range(-7.5f, 7.5f), Player.transform.position.y + (8 + Random.Range(0.2f, 1.0f))), Quaternion.identity);
            }
            else
            {
                Destroy(collision.gameObject);
                Instantiate(Platform, new Vector2(Random.Range(-10.5f, 10.5f), Player.transform.position.y + (8 + Random.Range(0.2f, 1.0f))), Quaternion.identity);
            }
        } else if (collision.gameObject.name.StartsWith("Moving"))
        {
            if ((rand = Random.Range(1, 9)) == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(ExtraBouncy, new Vector2(Random.Range(-7.5f, 7.5f), Player.transform.position.y + (8 + Random.Range(0.2f, 1.0f))), Quaternion.identity);
            }
            else if ((rand = Random.Range(1, 4)) == 1)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-10.5f, 10.5f), Player.transform.position.y + (8 + Random.Range(0.2f, 1.0f)));      
            }
            else
            {
                Destroy(collision.gameObject);
                Instantiate(Platform, new Vector2(Random.Range(-10.5f, 10.5f), Player.transform.position.y + (8 + Random.Range(0.2f, 1.0f))), Quaternion.identity);
            }
        } else if (collision.gameObject.name.StartsWith("Sprinkle"))
        {
            collision.gameObject.transform.position = new Vector2(Random.Range(-10.5f, 10.5f), Player.transform.position.y + (8 + Random.Range(0.2f, 1.0f)));
        }
        
        
        
        
        //Destroy(collision.gameObject);
        //myPlat = (GameObject)Instantiate(Platform, new Vector2(Random.Range(-5.5f, 5.5f), Player.transform.position.y + (14 + Random.Range(0.5f, 0.8f))), Quaternion.identity);

        //if (Random.Range(1, 6) == 1)
        //{
        //    Instantiate(ExtraBouncy, new Vector2(myPlat.transform.position.x, myPlat.transform.position.y + .4f), Quaternion.identity);
        //}

    }

}
