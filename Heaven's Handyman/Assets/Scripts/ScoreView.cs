using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class ScoreView : MonoBehaviour {

    //public GameObject scoreDisplay; 

    Text text2;

    void Awake() {


        text2 = GetComponent<Text>();

    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate() {

   


            //print the score dynamically to the screen for the player to see. 
            text2.text = "Your Score for this run is: " + Globals.score + " people saved.";

        

    }//end of fixed update
}
