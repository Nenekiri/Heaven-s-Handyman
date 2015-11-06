using UnityEngine;
using System.Collections;

public class playerControls : MonoBehaviour {

	public Transform wall; 

	public float speed = 1.0f;
	public float JumpSpeed = 2.0f; 
	public float fallSpeed = 2.5f; 

	public float ascentTime = 0.0f; 

	public Rigidbody2D rb;

    private tk2dSpriteAnimator anim;

    public AudioSource audios;
    public AudioClip wingflap;

    public int swiftPowerupTimer = 0;
    public bool swiftBool = false;

    public GameObject bootImage;

    public int haloPowerupTimer = 0;
    public GameObject haloImage;

    public int featherPowerupTimer = 0;
    public bool featherBool = false;
    public GameObject featherImage;

    public AudioClip featherSound;
    public AudioClip swiftSound;
    public AudioClip haloSound; 
    


    // Use this for initialization
    void Start () {

         


    rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<tk2dSpriteAnimator>();
        audios = GetComponent<AudioSource>();
        bootImage = GameObject.Find("Boot Image");
        bootImage.SetActive(false);

        haloImage = GameObject.Find("Halo Image");
        haloImage.SetActive(false);

        featherImage = GameObject.Find("Feather Image");
        featherImage.SetActive(false);

        featherBool = false;
        swiftBool = false;
        Globals.haloBool = false; 
    }


    void FixedUpdate() {

        //updates the position of the player
        Globals.distanceTraveledX = transform.localPosition.x;
        Globals.distanceTraveledY = transform.localPosition.y;
        //checks for the position of the player in the y-axis and will "kill" the player 
        //when he goes past the y-position of the wall of death. 
        if (this.transform.position.y <= wall.transform.position.y) {

            //Application.LoadLevel("Test"); 

            Globals.death = true;

        }

        //powerup logic section
        if (swiftBool == true) {

            swiftPowerupTimer++; 
        }

        if (swiftPowerupTimer >= 600) {
            swiftBool = false; 
            swiftPowerupTimer = 0;
            speed = 6.0f;
            bootImage.SetActive(false); 
        }

        if (featherBool == true)
        {

            featherPowerupTimer++;
        }

        if (featherPowerupTimer >= 600)
        {
            featherBool = false;
            featherPowerupTimer = 0;
            JumpSpeed = 11.0f;
            fallSpeed = 8.0f; 
            featherImage.SetActive(false);
        }

        if (Globals.haloBool == true) {

            haloPowerupTimer++; 
        }

        if (haloPowerupTimer >= 600) {

            Globals.haloBool = false;
            haloPowerupTimer = 0;
            haloImage.SetActive(false); 

        }

        //basic movement for the character

        //this method allows for movement both on the horizontal and vertical axis
        //var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        //this method only allows horizontal movement
        Vector2 move = new Vector2(Input.GetAxis("Horizontal"), 0);

        /*if (Input.GetButtonUp("Jump") == false) { 
        //play the animations for walking
        if (move.x < 0)
        {
            anim.Play("handyman_walkleft");
        }
        else if (move.x > 0) {
            anim.Play("handyman_walk");
        }
    }//end of walking check */
        
		//transform.position += move * speed * Time.deltaTime;
		
		float grav = rb.velocity.y - 0.25f; 
		rb.velocity = move * speed * Time.deltaTime * 100;
		
		
		
		if(Input.GetButtonUp("Jump") == true){
			
			//rb.velocity = new Vector3 (0, 10, 0); 
			
			//var moveVertTemp = new Vector3(0, JumpSpeed, 0); 
			//transform.position += moveVertTemp * Time.deltaTime;
			
			grav = 9.5f; 
			
			
			
		} 
		
		rb.velocity = new Vector2(rb.velocity.x, grav); 
		
		
		
		//this method allows for jumping and holding down the jump key to ascend
		//var moveVert = new Vector3(0, Input.GetAxis("Jump"), 0); 
		//transform.position += moveVert * JumpSpeed * Time.deltaTime; 

		if(Input.GetButtonDown("Jump") == true){

			grav = 10.5f;

            //switching the animation based on the input from the player
            if (move.x < 0)
            {
                anim.Play("handyman_wingflapleft");
                audios.PlayOneShot(wingflap, 1);
            }
            else if (move.x > 0)
            {
                anim.Play("handyman_wingflap");
                audios.PlayOneShot(wingflap, 1);
            }

        }
		
		rb.velocity = new Vector2(rb.velocity.x, grav); 
		
		
		//used for quickly dropping down
		
		if(Input.GetAxis("Vertical") < 0){
			
			var moving = new Vector3(0, fallSpeed, 0); 
			//transform.position -= moving * Time.deltaTime; 
			
			rb.velocity = -moving * Time.deltaTime * 100; 
			

			//Debug.Log(fallSpeed); 
		}

        Debug.Log("swift power up time:" + swiftPowerupTimer);
		
		//much less effective way of dropping the character
		//var moveDown = new Vector3(0, Input.GetAxis("Vertical"), 0); 
		//transform.position -= moveDown * fallSpeed * Time.deltaTime;  



	}
	// Update is called once per frame
	void Update () {




	
	}//end of update

	void OnTriggerEnter2D(Collider2D other){

		Debug.Log ("Hit"); 
		if (other.tag == "Wall"){

            //Application.LoadLevel("Test");

            Globals.death = true;     
         
		}

        if (other.tag == "halo powerup") {

            //resets the counter so that if the player comes in contact with another one, the time increases
            haloPowerupTimer = 0;

            //play the sound effect
            audios.PlayOneShot(haloSound, 1);


            //destroy the powerup
            Destroy(other.gameObject);

            //start the timer
            Globals.haloBool = true;

            haloImage.SetActive(true);


        }

        if (other.tag == "swift powerup") {
            //resets the counter so that if the player comes in contact with another one, the time increases
            swiftPowerupTimer = 0;

            //play the sound effect
            audios.PlayOneShot(swiftSound, 1);

            //destroy the powerup
            Destroy(other.gameObject);

            //adjust the player's speed
            speed = 10.0f;

            //start the timer
            swiftBool = true;

            bootImage.SetActive(true); 
             
        }

        if (other.tag == "feather powerup")
        {
            //resets the counter so that if the player comes in contact with another one, the time increases
            featherPowerupTimer = 0;

            //play the sound effect
            audios.PlayOneShot(featherSound, 1);


            //destroy the powerup
            Destroy(other.gameObject);

            //adjust the player's jump speed
            JumpSpeed = 14.0f;

            //adjust the player's fall speed
            fallSpeed = 5.0f; 

            //start the timer
            featherBool = true;

            featherImage.SetActive(true);

        }


    }//end of OnTriggerEnter2D

    void OnCollisionStay2D(Collision2D col) {

        if (col.gameObject.tag == "Platform")
        {

            Vector2 move2 = new Vector2(Input.GetAxis("Horizontal"), 0);

            //play the animations for walking
            if (move2.x < 0)
            {
                anim.Play("handyman_walkleft");
            }
            else if (move2.x > 0)
            {
                anim.Play("handyman_walk");
            }
        }//end of the walking cycle if

        

    }//end of OnCollisionStay2D

  


}//end of class