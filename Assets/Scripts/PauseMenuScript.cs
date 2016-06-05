using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityTwine;

public class PauseMenuScript : MonoBehaviour {
	public GameObject pauseMenu;
	public GameObject[] menus; //0 = main; 1 = save
	public Story storyScript;
	string[] vars;

	void Start() {
		vars = new string[] {
			"fail",
			"metFriend",
			"morals",
			"sociability",
			"suspicion"
		};
		int i = PlayerPrefs.GetInt("shouldLoadLevel");
		if (i > 0) {
			Load(i);
		}
		Resume();
	}

	void Load(int slot) {
		string passageName = PlayerPrefs.GetString ("SavedLevel" + slot.ToString());
		Debug.Log("Load: " + passageName);
		string paramsValue = PlayerPrefs.GetString("paramsValue" + slot.ToString());
		string[] paramsValues = paramsValue.Split('|');
		long i = 0;
		foreach (string pValue in paramsValues) {
			TwineVar var = new TwineVar(pValue);
			storyScript[vars[i]] = var;
			i++;
		}
		storyScript.GoTo(passageName);
		Resume();
	}

	void Update() {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			if (pauseMenu.activeSelf == false) {
				pauseMenu.SetActive(true);
			} else {
				Resume();
			}
		}
	}

	void addParamToString(ref string paramValue, string param) {
		if (paramValue.Length > 0) {
			paramValue += "|";
		}
		paramValue += storyScript[param].ToInt().ToString();
	}

	//TODO save summary
	public void Save(int slot) {
		Debug.Log("Save: " + storyScript.CurrentPassageName + " in slot " + slot.ToString());
		PlayerPrefs.SetString("SavedLevel" + slot.ToString(), storyScript.CurrentPassageName);
		string paramsValue = "";
		foreach (string var in vars) {
			//if summary
			//PlayerPrefs.SetString("Summary" + slot.ToString(), summary);
			//else
			addParamToString(ref paramsValue, var);
		}
		Debug.Log(paramsValue);
		PlayerPrefs.SetString("paramsValue" + slot.ToString(), paramsValue);
	}

	public void Resume() {
		pauseMenu.SetActive(false);
	}

	public void GoToSaveMenu() {
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

	public void Return() {
		foreach (GameObject go in menus) {
			go.SetActive(false);
		}
		menus[0].SetActive(true);
	}

	public void ReturnToMain() {
		Application.LoadLevel("Menu");
	}

	public void Quit() {
		Application.Quit();
	}
}
