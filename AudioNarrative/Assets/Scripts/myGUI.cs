using UnityEngine;
using System.Collections;

public class myGUI : MonoBehaviour {
	public GUISkin guiSkin; // Assigned via inspector

	public bool songComplete = false;
	public bool songStarted = false;
	public int score = 0;

	void OnGUI(){
		// Assign this GUI's skin to the skin assigned via inspector
		GUI.skin = guiSkin;
	
		GUI.Label(new Rect(Screen.width*5/32, Screen.height*6/32,Screen.width*2/2, Screen.height*6/32), "How To:");
		GUI.Label(new Rect(Screen.width*5.25f/32, Screen.height*7.5f/32,Screen.width*2/2, Screen.height*6/32), "-Listen to the sound narrative");
		GUI.Label(new Rect(Screen.width*5.25f/32, Screen.height*9/32,Screen.width*2/2, Screen.height*6/32), "-Play the correct bird chirps at the right time in the song");
		GUI.Label(new Rect(Screen.width*5.25f/32, Screen.height*10.5f/32,Screen.width*2/2, Screen.height*6/32), "-Hint: Listen for sequences of bird chirps and try to fill in the sequence!");
		
		
		GUI.Label(new Rect(Screen.width*5f/32, Screen.height*13/32,Screen.width*2/2, Screen.height*6/32), "Controls:");
		GUI.Label(new Rect(Screen.width*5.25f/32, Screen.height*14.5f/32,Screen.width*2/2, Screen.height*6/32), "Spacebar to chirp");
		
		if(songComplete == true){
			GUI.Label(new Rect(Screen.width*5.25f/32, Screen.height*18/32,Screen.width*2/2, Screen.height*6/32), "Final score: " + score.ToString() + "/22");
		}
		if(songStarted == false){
			GUI.Label(new Rect(Screen.width*5.25f/32, Screen.height*18/32,Screen.width*2/2, Screen.height*6/32), "Press P to Start");
		}
	}
}
