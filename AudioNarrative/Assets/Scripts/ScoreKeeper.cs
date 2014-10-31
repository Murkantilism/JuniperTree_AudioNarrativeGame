using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScoreKeeper : MonoBehaviour {

	//Dictionary<float, float> timestamps;
	
	ArrayList timestamps;
	
	myGUI mygui;
	
	public GameObject birdChip;
	
	bool songStarted = false;

	// Use this for initialization
	void Start () {
		timestamps = new ArrayList();
		// Timestamp windows for each bird chirp
		timestamps.Add(12.0f);
		timestamps.Add(13.50f);
		
		timestamps.Add(22.0f);
		timestamps.Add(23.75f);
		
		timestamps.Add(41.0f);
		timestamps.Add(42.25f);
		
		timestamps.Add(49.75f);
		timestamps.Add(51.25f);
		
		timestamps.Add(57.25f);
		timestamps.Add(58.75f);
		
		timestamps.Add(68.5f);
		timestamps.Add(70.25f);
		
		timestamps.Add(79.6f);
		timestamps.Add(81.25f);
		
		timestamps.Add(84.9f);
		timestamps.Add(86.5f);
		
		timestamps.Add(112.6f);
		timestamps.Add(114.0f);
		
		timestamps.Add(122.0f);
		timestamps.Add(123.75f);
		
		timestamps.Add(135.5f);
		timestamps.Add(137.0f);
		
		timestamps.Add(146.75f);
		timestamps.Add(148.30f);
		
		timestamps.Add(160.6f);
		timestamps.Add(162.25f);
		
		timestamps.Add(168.0f);
		timestamps.Add(169.5f);
		
		timestamps.Add(173.5f);
		timestamps.Add(175.05f);
		
		timestamps.Add(195.6f);
		timestamps.Add(197.10f);
		
		timestamps.Add(201.23f);
		timestamps.Add(202.30f);
		
		timestamps.Add(214.95);
		timestamps.Add(216.65); // Eeeaaagle!
		
		timestamps.Add(217.84f);
		timestamps.Add(219.25f);
		
		timestamps.Add(227.05f);
		timestamps.Add(228.20f);
		
		timestamps.Add(232.60f);
		timestamps.Add(234.0f);
		
		timestamps.Add(245.50f);
		timestamps.Add(247.10f);
		
		timestamps.Add(254.75f);
		timestamps.Add(256.30f);
				
		mygui = GameObject.Find("GUI").GetComponent<myGUI>();
	}

	// Update is called once per frame
	void Update () {
		GetInput();
	}
	
	// Each time the player hits spacebar, get the current time in the song and check
	// if that timestamp is in between one of the float pairs in timestamps list.
	void GetInput(){
		if(Input.GetKeyUp(KeyCode.Space)){
			// If the bird chirp isn't already playing
			if(birdChip.audio.isPlaying == false){
				birdChip.audio.Play();
				CheckList(audio.time);
			}
		}
		if(Input.GetKeyUp(KeyCode.P)){
			gameObject.audio.Play();
			mygui.songStarted = true;
			songStarted = true;
		}
		// If the song's been started
		if(songStarted == true){
			// and has finished playing, we're done!
			if(gameObject.audio.isPlaying == false){
				mygui.songComplete = true;
			}
		}
	}
	
	// Given a timestamp in the song, check if it is in between one of the float pairs in timestamps list
	void CheckList(float t){
		// Check if the given timestamp t is in between the first two elements of the list,
		// then check the next two, so on and so forth
		for (int i = 0; i < timestamps.Count; i+=2){
			if(in_between(t, (float)timestamps[i], (float)timestamps[i+1])){
				// If it is, we have a match! Increment score
				Debug.Log("Match found at: " + t);
				mygui.score += 1;
			}
		}
	}
	
	// Helper method to check if float V is in between float L and R
	bool in_between(float value, float left, float right)
	{ 
		return value > left && value < right; 
	}
}
