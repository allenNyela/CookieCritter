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
    public int numberToGrow = 1;
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
    public Sprite eatingSprite1;
    public Sprite eatingSprite2;
    public Sprite eatingSprite3;
    public Sprite eatingSprite4;
    public Sprite eatingSprite5;
    private List<Sprite> Stages = new List<Sprite>();

    private void Start()
    {
        Stages.Add(frontFacingSprite1);
        Stages.Add(frontFacingSprite2);
        Stages.Add(frontFacingSprite3);
        Stages.Add(frontFacingSprite4);
        Stages.Add(frontFacingSprite5);
    }

    public void checkVersion(){
        //changes the sprite version based on number of flour eaten
        for(int i = 1; i <= 5; i++){
            if(GameManager.numberFlourEaten >= (i - 1) * numberToGrow){
                spriteVersion = i;
                GameManager.Player = Stages[i - 1];
            }
        }
    }

    void Update()
    {
        checkVersion();
        speed = 0.5f;
        var step =  speed * Time.deltaTime; // calculate distance to move
        if(GameManager.flourClicked){
            //swap sprite to the eating one 
            if(spriteVersion == 1){
                this.GetComponent<SpriteRenderer>().sprite = eatingSprite1;
            }
            else if(spriteVersion == 2){
                this.GetComponent<SpriteRenderer>().sprite = eatingSprite2;
            }
            else if(spriteVersion == 3){
                this.GetComponent<SpriteRenderer>().sprite = eatingSprite3;
            }
            else if(spriteVersion == 4){
                this.GetComponent<SpriteRenderer>().sprite = eatingSprite4;
            }
            else {
                this.GetComponent<SpriteRenderer>().sprite = eatingSprite5;
            }
    
            //if it hasnt reached the flour 
            if(transform.position != new Vector3 (-1.08f, -0.218f)){
                if (transform.position.x >= -1.08f)
                {
                    if (spriteVersion == 1) {
                        this.GetComponent<SpriteRenderer>().flipX = false;
                    } else
                    {
                        this.GetComponent<SpriteRenderer>().flipX = true;
                    }
                    
                } else
                {
                    if (spriteVersion == 1)
                    {
                        this.GetComponent<SpriteRenderer>().flipX = true;
                    }
                    else
                    {
                        this.GetComponent<SpriteRenderer>().flipX = false;
                    }
                    //this.GetComponent<SpriteRenderer>().flipX = false;
                }
                transform.position = Vector3.MoveTowards(transform.position, new Vector3 (-1.08f, -0.218f), step);
            }
            //if it has reached the flour 
            else{
                //GameManager.numberFlourEaten += 1;
                GameManager.flourClicked = false;
                checkVersion();
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
                Debug.Log(GameManager.numberFlourEaten);
            }
        }  
        else if (timer <= 0 ){
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.name.StartsWith("DoughIdle"))
        //{
        if (collision.gameObject.name.StartsWith("Flour"))
        {
            if (GameManager.flourClicked)
            {
                //Debug.Log("Collision!!");
                GameManager.numberFlourEaten += 1;
                Debug.Log(GameManager.numberFlourEaten);
                Destroy(collision.gameObject);
            }
            
        }
    }
}



// move to flour
//call consume function
//increase flour counter 

//Flour count
//30 between each stage
