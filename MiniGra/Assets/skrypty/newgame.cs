using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newgame : MonoBehaviour {
	public GUISkin menuSkin;
	public Rect menuArea;
	public Rect playButton;
	public Rect scoreButton;
	public Rect quitButton;


	Rect normalizedMenuArea;

	void Start()
	{
		normalizedMenuArea = new Rect(menuArea.x * Screen.width - (menuArea.width * 0.5f),
			menuArea.y * Screen.height - (menuArea.height * 0.5f),
			menuArea.width, menuArea.height);
	}

	void OnGUI() 
	{
		GUI.skin = menuSkin;

		GUI.BeginGroup(normalizedMenuArea);
		if(GUI.Button(new Rect(playButton), "Play")) {
			Destroy(GameObject.Find("Odleglosc"));
			Application.LoadLevel(0);	
		}

		if(GUI.Button(new Rect(scoreButton), "")) {
			Application.LoadLevel("Scores");	
		}

		if(GUI.Button(new Rect(quitButton), "Quit")) {
			Application.Quit();
			Debug.Log ("Have Quit");
		}
		GUI.EndGroup();
	}



}
