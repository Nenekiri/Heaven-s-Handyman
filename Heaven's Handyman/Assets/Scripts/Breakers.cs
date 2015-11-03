using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class Breakers : MonoBehaviour {

    public Sprite breakerOff;
    public Sprite breakerOn;

    public int buttonPresses = 0;
    public bool interact = false;
     

    //public int timer = 0; 

    public GameObject breakerDisplay; 

   

    public Rigidbody2D rb;

    void Awake() {

        //breakerDisplay = GameObject.Find("Interact");
        //breakerDisplay.SetActive(false); 

    }


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        interact = false;
        breakerDisplay.SetActive(false);

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
        if (interact == false)
        {
            Globals.score += 100;
        }

        Debug.Log(Globals.score);

        //gets rid of the display when the switch is flipped
        //breakerDisplay.SetActive(false);

        //buttonPresses = 0; 

        //timer = 0; 

    }

    //a way to check for the collsion using rigidbody that is woken up every frame
    void OnCollisionStay2D(Collision2D coli)
    {
        Debug.Log("Hit Breaker");
        if (coli.gameObject.tag == "Player")
        {
           
                //display a message over the breaker object that signals the player needs to interact with it
                breakerDisplay.SetActive(true);
            
                           


                //changed it to a type of quick time event that checks for the amount of button presses that player has done while next to the button and if the limit is 
                //reached then run the functions that switch the sprite and add the score. 
                if (Input.GetButtonUp("Fire1"))
                {
                buttonPresses++;
                if (buttonPresses == 6) {

                    this.GetComponent<SpriteRenderer>().sprite = breakerOn;
                    checkScore();

                    interact = true;

                    Globals.message = true; 

                    

                }//end of buttonPresses check

                }//end of check for button press 


        }//end of check for player collision

    }//end of collision check

    //check for the player leaving the breaker switch
    void OnCollisionExit2D(Collision2D coli) {

        if (coli.gameObject.tag == "Player") {

            breakerDisplay.SetActive(false);
            Globals.message = false;  
        }

    }//end of OnCollisionExit2D

    public void Reset() {
        
        interact = false;
        buttonPresses = 0;
        this.GetComponent<SpriteRenderer>().sprite = breakerOff;

    }



}//end of class
