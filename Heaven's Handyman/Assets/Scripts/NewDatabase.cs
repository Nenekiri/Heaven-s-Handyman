using UnityEngine;
using System.Collections;

public class NewDatabase : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }//end of update

    IEnumerator Submit() {

        //public static int highScore = 200;
    WWW www = new WWW("http://www.cit351nenekiri.com/scores.php?high=" + PlayerPrefs.GetInt("highscore"));
    yield return www;
        
        string result = www.text;   

    }

IEnumerator GetScores() {

    WWW www = new WWW("http://www.cit351nenekiri.com/scores.php?high=get");
    yield return www;

    string result = www.text;

        string[] scores = result.Split(',');

        foreach (string s in scores) {
            //do with each score as I please
            //int score = int(s); 

        }

}


}//end of class definition
