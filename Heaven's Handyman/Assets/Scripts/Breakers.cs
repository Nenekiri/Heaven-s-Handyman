using UnityEngine;
using System.Collections;

public class Breakers : MonoBehaviour {

    public Sprite breakerOff;
    public Sprite breakerOn;

    int score = 0; 


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate() {



    }//end of fixed update

    void checkScore() {

        score += 100;

        Debug.Log(score); 

    }

}
