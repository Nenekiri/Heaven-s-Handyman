using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class UIManager : MonoBehaviour {

	public GameObject pausePanel;

	public bool isPaused;

    public GameObject DeathPanel;

    public GameObject score;

    public GameObject player; 

    int timer = 0;

    //public ScoreView View; 
   
    
    




	

	// Use this for initialization
	void Start () {

		isPaused = false;

        //sets the Death Panel to be false on start
        DeathPanel.SetActive(false);

        player.SetActive(true); 

        
    }
	
	// Update is called once per frame
	void Update () {


		if (isPaused) {
			PauseGame (true); 
		} else {
			PauseGame(false); 
		}

        //checks to make sure the player isn't dead before pausing
        if (Globals.death == false)
        {
            if (Input.GetButtonDown("Cancel"))
            {
                SwitchPause();
            }
        }

        if (Globals.death == true) {

            //View.CheckScore(); 
            DeathScreen(); 

        }

	}

	void PauseGame(bool state){

		if (state) {


			Time.timeScale = 0.0f; 

		} else {

			Time.timeScale = 1.0f; 


		}

		pausePanel.SetActive (state); 

	}//end of PauseGame method

	public void SwitchPause(){

        if (Globals.death == false)
        {
            if (isPaused)
            {

                isPaused = false; //changes the value
            }
            else
            {
                isPaused = true;
            }

        }


	}//end of switchPause method

	public void ChangeScene(string scene){

		Application.LoadLevel (scene);

        //forces the value for player death to be false when transitioning between scenes. 
        Globals.death = false;

        //forces the score to reset when switching between scenes
        Globals.score = 0;

        Globals.scoreSubmit = false; 

        //resets the values for the music playing
        Globals.heaven = false;
        Globals.hell = false; 

	}

    public void DeathScreen() {

        //sets the score to be false
        score.SetActive(false); 

        //sets the death panel on
        DeathPanel.SetActive(true);


        if (Globals.death == true)
        {
            //disables the player object so that you can't see it anymore
            player.SetActive(false);

            timer++; 
            if (timer >= 60)
            { 
                //pauses the game scene while they are viewing their results
                Time.timeScale = 0.0f;
                 
            }
        }
        

       
    }

    //allows me to assign this function to a button as a retry/reload button for the level. 
    public void Reload() {

        //loads the current level and resets the death variable
        Application.LoadLevel(Application.loadedLevel);
        Globals.death = false;

        //resets the panel components for the reloaded scene
        DeathPanel.SetActive(false);
        score.SetActive(true);
         

        //unpauses the game
        Time.timeScale = 1.0f;

        //resets the variable for the score
        Globals.score = 0;

        timer = 0;

        Globals.scoreSubmit = false; 


    }//end of reload method

    //attempt to make setactive easier, ehh not the best method
    void FlipActivation(GameObject g) {

        if (g.activeSelf == true)
        {

            g.SetActive(false);
        }
        else if (g.activeSelf == false) {

            g.SetActive(true); 
        }

    }







}
