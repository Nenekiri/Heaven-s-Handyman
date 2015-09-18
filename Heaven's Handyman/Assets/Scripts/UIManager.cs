using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class UIManager : MonoBehaviour {

	public GameObject pausePanel; 

	public bool isPaused; 

	// Use this for initialization
	void Start () {

		isPaused = false; 
	
	}
	
	// Update is called once per frame
	void Update () {
		if (isPaused) {
			PauseGame (true); 
		} else {
			PauseGame(false); 
		}

		if(Input.GetButtonDown ("Cancel")){
			SwitchPause(); 
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

		if (isPaused) {

			isPaused = false; //changes the value
		} else {
			isPaused = true; 
		}


	}//end of switchPause method

}
