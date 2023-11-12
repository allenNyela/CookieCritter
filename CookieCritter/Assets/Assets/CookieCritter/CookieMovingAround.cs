using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieMovingAround : MonoBehaviour
{
    // Adjust the speed for the application.
    public float speed = 0.5f;
    public float xVal = 0f;
    public float yVal = -0.151f;
    public float timer = 3.5f; 
    public Sprite frontFacingSprite;
    public Sprite leftFacingSprite;
    public Sprite rightFacingSprite;


//want to add on click function where 
    void Update()
    {
        speed = 0.5f;
        var step =  speed * Time.deltaTime; // calculate distance to move
        if (timer <= 0 ){
            xVal = Random.Range(-1.26f, 1.26f);
            yVal = Random.Range(-0.31f, 0.13f);
            //moving to the right
            if(xVal > transform.position.x){
                this.GetComponent<SpriteRenderer>().sprite = rightFacingSprite;
            }
            //moving to the left
            if(xVal < transform.position.x){
                this.GetComponent<SpriteRenderer>().sprite = leftFacingSprite;
            }
            timer = 3.5f;
        }
        else{
            timer -= Time.deltaTime;
            //if it still needs to move to reach location keep moving
            if(transform.position != new Vector3 (xVal, yVal)){
                transform.position = Vector3.MoveTowards(transform.position, new Vector3 (xVal, yVal), step);
            }
            //if it has reached its location
            else{
                this.GetComponent<SpriteRenderer>().sprite = frontFacingSprite;
                //add a pause here? idk how ):
                    //can I also pause the wobble animation at this part?
            }

        }
    }
}
