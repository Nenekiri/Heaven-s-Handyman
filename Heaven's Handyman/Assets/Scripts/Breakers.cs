using UnityEngine;
using System.Collections;

public class Breakers : MonoBehaviour {

    public Sprite breakerOff;
    public Sprite breakerOn;

    public int buttonPresses = 0; 

    //public int timer = 0; 

   

    public Rigidbody2D rb;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate() {

         

        //allows the rigidbody to be woken up every couple of frames. 
        if (rb.IsSleeping())
        {
            rb.WakeUp();
        }

    }//end of fixed update

    void checkScore() {

        Globals.score += 100;

        Debug.Log(Globals.score);

        buttonPresses = 0; 

        //timer = 0; 

    }

    //a way to check for the collsion using rigidbody that is woken up every frame
    void OnCollisionStay2D(Collision2D coli)
    {
        Debug.Log("Hit Breaker");
        if (coli.gameObject.tag == "Player")
        {

                //changed it to a type of quick time event that checks for the amount of button presses that player has done while next to the button and if the limit is 
                //reached or exceeded then run the functions that switch the sprite and add the score. 
                if (Input.GetButtonUp("Fire1"))
                {
                buttonPresses++;
                if (buttonPresses >= 7) {

                    this.GetComponent<SpriteRenderer>().sprite = breakerOn;
                    checkScore();

                }//end of buttonPresses check

                }//end of check for button press 


        }//end fo check for player collision

    }//end of collision check



}//end of class
