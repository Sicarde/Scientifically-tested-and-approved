using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class MainMenuScript : MonoBehaviour {
	public GameObject[] menus; //0 == MainMenu; 1 == LoadSlot; 2 == Credits

	public void Play() {
		Debug.Log("Play");
		Application.LoadLevel("Test");
	}
	
/*	public void Settings() {
		Debug.Log("Settings");
		menus[0].SetActive(false);
		menus[2].SetActive(true);
	}*/
	
	public void Load(int slot) {
		if (slot > 0) {
			PlayerPrefs.SetInt ("shouldLoadLevel", slot);
		} else {
			PlayerPrefs.SetInt ("shouldLoadLevel", 0);
		}
		Application.LoadLevel("Test");
	}

	public void GoToSlotSelection() {
		Debug.Log("go to slot");
		menus[0].SetActive(false);
		menus[1].SetActive(true);
		GameObject[] slots = GameObject.FindGameObjectsWithTag("Slot");
		foreach (GameObject s in slots) {
			Text[] childTexts = s.GetComponentsInChildren<Text>();
			Text summaryText = childTexts[0];
			foreach (Text t in childTexts) {
				if (t.name == "Summary") {
					summaryText = t;
				}
			}
			int i = 1;
			while (i <= 3) {
				string summ = PlayerPrefs.GetString("Summary" + i.ToString());
				if (summ.Length == 0) {
					PlayerPrefs.SetString("SavedLevel" + i.ToString(), "Beginning");
					PlayerPrefs.SetString("paramsValue" + i.ToString(), "");
					PlayerPrefs.SetString("Summary" + i.ToString(), "Empty slot");
				}
				summaryText.text = summ;
				i++;
			}
		}
	}

	public void Credits() {
		Debug.Log("Credits");
		menus[0].SetActive(false);
		menus[2].SetActive(true);
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
