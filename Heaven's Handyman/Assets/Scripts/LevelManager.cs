using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class LevelManager : MonoBehaviour {

    //make sure to make all of the prefabs the same size, this will save me from many headaches later on. 

    //setting up all the variables 

    public GameObject[] pieces;

    public int maxSize = 5;

    List<GameObject> links;

    public float cutOff = 30.0f;

    public Vector3 lastPlaced = Vector3.zero;  

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (links.Count < maxSize) {

            //spawn a new object
            //pieces[Random.Range(0, 7)]; 

            /*for(pieces){
                
                if(pieces = false){
                
                remove from the list
                }    
                else{
                
                    for(i = pieces.Count){
                            
                            Vector3.Length(pieces[].transform.position.y) += transform.position); 
                        }
                    }

            }*/


        }//end of check for how many prefabs are currently in the scene
	
	}
}
