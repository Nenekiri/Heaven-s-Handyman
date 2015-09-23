using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class ScoreManager : MonoBehaviour {

    Text text;


    //called as the first thing that happens in the scene
    void Awake()
    {

        text = GetComponent<Text>();

       
            Globals.score = 0;
        
    


    }

	// Use this for initialization
	void Start () {
	
	}

    void FixedUpdate() {

        //print the score dynamically to the screen for the player to see. 
        text.text = "Score: " + Globals.score;


    }//end of fixed update
	
	// Update is called once per frame
	void Update () {
	
	}
}
