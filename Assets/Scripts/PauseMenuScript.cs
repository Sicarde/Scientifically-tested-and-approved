using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityTwine;

public class PauseMenuScript : MonoBehaviour {
	public GameObject pauseMenu;
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
		Resume();
	}

	public void Load(string passageName) {
		if (passageName == "") {
			passageName = PlayerPrefs.GetString ("SavedLevel");
		}
		Debug.Log("Load: " + passageName);
		string paramsValue = PlayerPrefs.GetString("paramsValue");
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
		if(Input.GetKeyDown(KeyCode.P)) {
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

	public void Save() {
		Debug.Log("Save: " + storyScript.CurrentPassageName);
		PlayerPrefs.SetString("SavedLevel", storyScript.CurrentPassageName);
		string paramsValue = "";
		foreach (string var in vars) {
			addParamToString(ref paramsValue, var);
		}
		Debug.Log(paramsValue);
		PlayerPrefs.SetString("paramsValue", paramsValue);
	}

	public void Resume() {
		Debug.Log("Resume");
		pauseMenu.SetActive(false);
	}
}
