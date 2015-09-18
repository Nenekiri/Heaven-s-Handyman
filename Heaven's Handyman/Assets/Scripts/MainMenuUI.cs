using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class MainMenuUI : MonoBehaviour {

	public GameObject mainMenu; 

	public Toggle MusicToggle; 
	public Toggle MusicToggle2; 

	// Use this for initialization
	void Start () {
 
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SwitchMusicHeaven(){

		//MusicToggle.isOn = !MusicToggle.isOn;
		
		if(MusicToggle.isOn) {
			Globals.heaven = true; 
			Globals.hell = false;  

		} 
		
	}
	
	public void SwitchMusicHell(){
		
		if(MusicToggle2.isOn) {
			Globals.heaven = false; 
			Globals.hell = true; 

		} 
		
	}

	public void ChangeScene(string scene){
		
		Application.LoadLevel (scene); 
		
		
	}
}
