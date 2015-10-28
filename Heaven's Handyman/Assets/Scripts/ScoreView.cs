using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class ScoreView : MonoBehaviour {

    //public GameObject scoreDisplay; 


    Text text2;

    void Awake() {
        //PlayerPrefs.SetInt("highscore", 0); 


        text2 = GetComponent<Text>();

    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ClearScore() {

        PlayerPrefs.DeleteKey("highscore"); 

    }

    IEnumerator Submit()
    {

        
        WWW www = new WWW("http://www.cit351nenekiri.com/scores.php?high=" + PlayerPrefs.GetInt("highscore"));
        yield return www;

        string result = www.text;

    }

    IEnumerator GetScores()
    {

        WWW www = new WWW("http://www.cit351nenekiri.com/scores.php?high=get");
        yield return www;

        string result = www.text;

        string[] scores = result.Split(',');

        foreach (string s in scores)
        {
            //do with each score as I please
            //int score = int(s); 

        }

    }

    public void CheckScore() {

        Debug.Log(Globals.score + "current scene score"); 

        if (Globals.score == 0)
        {
            //print the score dynamically to the screen for the player to see. 
            text2.text = "Too Bad! You Didn't Save Anyone!";
        }
        else if (Globals.score > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", Globals.score);

            StartCoroutine(Submit());

            //print the score dynamically to the screen for the player to see. 
            text2.text = "New High Score! " + Globals.score + " people saved.";

        }
        else
        {

            //print the score dynamically to the screen for the player to see. 
            text2.text = "Your Score for this run is: " + Globals.score + " people saved.";

        }

    }

    void FixedUpdate() {

        /*if (PlayerPrefs.GetInt("highscore") < Globals.score)
        {
            PlayerPrefs.SetInt("highscore", Globals.score);
            Globals.highscore = Globals.score; 
        }*/

        

        Debug.Log(PlayerPrefs.GetInt("highscore") + " current highscore"); 

        if (Globals.death == true)
        {
            CheckScore();
        }

        

        

    }//end of fixed update
}
