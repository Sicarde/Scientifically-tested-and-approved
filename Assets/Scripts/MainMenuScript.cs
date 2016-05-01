using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class MainMenuScript : MonoBehaviour {
	public GameObject[] menus; //0 == MainMenu; 1 == Credits

	public void Play() {
		Debug.Log("Play");
		Application.LoadLevel("Test");
	}
	
/*	public void Settings() {
		Debug.Log("Settings");
		menus[0].SetActive(false);
		menus[2].SetActive(true);
	}*/

	public void Credits() {
		Debug.Log("Credits");
		menus[0].SetActive(false);
		menus[1].SetActive(true);
	}
	
	public void Exit() {
		Debug.Log("Exit");
		Application.Quit();
	}

	public void Return() {
		Debug.Log("Return");
		foreach (GameObject o in menus) {
			o.SetActive(false);
		}
		menus[0].SetActive(true);
	}
}
