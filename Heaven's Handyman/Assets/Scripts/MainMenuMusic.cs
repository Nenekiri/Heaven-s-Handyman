using UnityEngine;
using System.Collections;

public class MainMenuMusic : MonoBehaviour {

	public AudioSource s; 
	public AudioClip[] mclip;



	// Use this for initialization
	void Start () {

		s = GetComponent<AudioSource> ();
		
		s.clip = (mclip [Random.Range (0, mclip.Length * 7) % mclip.Length]); 
		
		s.Play ();

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
