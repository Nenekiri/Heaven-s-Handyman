using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour {

    //make sure to make all of the prefabs the same size, this will save me from many headaches later on. 

    //setting up all the variables 

    public GameObject[] pieces; //array to hold the public gameobjects

    public int maxSize = 5; //maxsize that can be in the list

    List<GameObject> links = new List<GameObject>(); //the list itself

    public float cutOff = 30.0f; //cutoff limit

    public Vector3 lastPlaced = Vector3.zero;  //vector to use for keeping track of the last placed gameobject

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        //checks for the size of the list called links and makes sure it is not greater than maxSize
        if (links.Count < maxSize)
        {

            //spawn a new object
            GameObject section = (GameObject)Instantiate(pieces[Random.Range(0, 7)], lastPlaced, transform.rotation);

            //add the object to the list
            links.Add(section);
        }


        //loop for cleanup, I think
        foreach (GameObject piece in links)
        {

            if (piece == false)
            {

                //remove from the list

                links.Remove(piece);

            } //end of if statement   
            else
            {

                for (int i = links.Count; i < links.Count; i++)
                {

                    //lastPlaced = Vector3.Length(pieces[i].transform.position.y) += transform.position;

            }//end of for loop
        }//end of else

    }//end of cleanup loop


}//end of update

}//end of class
