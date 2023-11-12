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
    public int spriteVersion = 1;
    public Sprite frontFacingSprite1;
    public Sprite rightFacingSprite1;
    public Sprite frontFacingSprite2;
    public Sprite rightFacingSprite2;
    public Sprite frontFacingSprite3;
    public Sprite rightFacingSprite3;
    public Sprite frontFacingSprite4;
    public Sprite rightFacingSprite4;
    public Sprite frontFacingSprite5;
    public Sprite rightFacingSprite5;


//want to add on click function where 
    void Update()
    {
        speed = 0.5f;
        var step =  speed * Time.deltaTime; // calculate distance to move
        if (timer <= 0 ){
            xVal = Random.Range(-1.26f, 1.26f);
            yVal = Random.Range(-0.31f, 0.13f);
            //switch to moving sprite
            if(spriteVersion == 1){
                this.GetComponent<SpriteRenderer>().sprite = rightFacingSprite1;
            }
            else if(spriteVersion == 2){
                this.GetComponent<SpriteRenderer>().sprite = rightFacingSprite2;
            }
            else if(spriteVersion == 3){
                this.GetComponent<SpriteRenderer>().sprite = rightFacingSprite3;
            }
            else if(spriteVersion == 4){
                this.GetComponent<SpriteRenderer>().sprite = rightFacingSprite4;
            }
            else {
                this.GetComponent<SpriteRenderer>().sprite = rightFacingSprite5;
            }


            //moving to the right
            if(xVal > transform.position.x){
                this.GetComponent<SpriteRenderer>().flipX = false;
            }
            //moving to the left
            if(xVal < transform.position.x){
                this.GetComponent<SpriteRenderer>().flipX = true;
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
                //change to idle sprite
                if(spriteVersion == 1){
                    this.GetComponent<SpriteRenderer>().sprite = frontFacingSprite1;
                }
                else if(spriteVersion == 2){
                    this.GetComponent<SpriteRenderer>().sprite = frontFacingSprite2;
                }
                else if(spriteVersion == 3){
                    this.GetComponent<SpriteRenderer>().sprite = frontFacingSprite3;
                }
                else if(spriteVersion == 4){
                    this.GetComponent<SpriteRenderer>().sprite = frontFacingSprite4;
                }
                else {
                    this.GetComponent<SpriteRenderer>().sprite = frontFacingSprite5;
                }
                //add a pause here? idk how ):
                //can I also pause the wobble animation at this part?
            }

        }
    }
}



// move to flour
//call consume function
//increase flour counter 