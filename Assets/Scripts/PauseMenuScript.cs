using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityTwine;

public class PauseMenuScript : MonoBehaviour {
	public GameObject pauseMenu;
	public TwineTextPlayer twineTextPlayer;

	public void Start()
	{
		Debug.Log("Load: " + PlayerPrefs.GetString ("SavedLevel"));
	}

	public void Update()
	{
		if(Input.GetKeyDown(KeyCode.P))
		{
			//this.gameObject.SetActive(true);
		}
	}

	public void Save() {
		TwineStory story = twineTextPlayer.Story;// GetComponentsInChildren<Story> ();
		Debug.Log("Save: " + story.CurrentPassageName);
		PlayerPrefs.SetString("SavedLevel",story.CurrentPassageName);
	}
	public void Resume() {
		Debug.Log("Resume");
		this.gameObject.SetActive(false);
	}
}
