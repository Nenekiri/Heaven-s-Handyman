using UnityEngine;
using System.Collections;

public class MusicSingleton : MonoBehaviour {


	//declares this script as a singleton, which means that there will only be one of these at all times even when transitioning between scenes
	private static MusicSingleton instance = null;
	public static MusicSingleton Instance {
		get { return instance; }
	}
	void Awake() {
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
	         instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}

	//declare some public variables I will need to get this functioning

	public AudioSource s; 

	public bool heaven = true; 
	public bool hell = false; 


	public AudioClip[] clip;
	public AudioClip[] hclip; 




	//on start get the audiocomponent for the audio source
	void Start(){


		RandomMusic (); 


	}

	//method for randomising music based on the player's choices

	void RandomMusic(){

		if (heaven == true) {

			s = GetComponent<AudioSource> ();
		
			s.clip = (clip [Random.Range (0, clip.Length * 7) % clip.Length]); 
		
			s.Play ();

		} else if (hell == true) {

			s = GetComponent<AudioSource> ();
			
			s.clip = (hclip [Random.Range (0, hclip.Length * 7) % hclip.Length]); 
			
			s.Play ();

		}



	}





}
