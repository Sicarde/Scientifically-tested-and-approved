using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ImagesManager : MonoBehaviour {
	public GameObject characterImageTemplate;
	public GameObject expressionImageTemplate;

	public List<Sprite> characters;
	public List<string> characterNames;
	public List<Sprite> charactersExpression;
	public List<string> indexOfExpressionAndPassageNameForExpressionChange;

	public string currentDisplayedCharacter = "";
	string _currentPassageName = "";
	Story _story;

	void Start() {
		_story = GameObject.FindObjectOfType<Story>();
	}

	public void ChangeCharacterImage(string characterName) {
		int i = 0;
		foreach (string s in characterNames) {
			if (s.Contains(characterName)) {
				characterImageTemplate.GetComponent<Image>().sprite = characters[i];
				currentDisplayedCharacter = s;
			}
			i++;
		}
	}
	
	public void ChangeExpressionImage(string passageName) {
		foreach (string s in indexOfExpressionAndPassageNameForExpressionChange) {
			if (s.Contains(passageName)) {
				expressionImageTemplate.GetComponent<Image>().sprite = charactersExpression[int.Parse(s.Substring(0, s.IndexOf(" ")))];
			}
		}
	}

	bool nameIsOk(string name) {
		return (name != "" && name != "(empty line)" && name != "/" && name != "//");
	}

	public void CheckTexts() {
		TextManager[] textsManagers = GameObject.FindObjectsOfType<TextManager>();
		int i = 0;
		TextManager other = null;
		foreach (TextManager tm in textsManagers) {
			if (i > 0 && nameIsOk(tm.name) && nameIsOk(name)) {
				tm.textToPrint = tm.textToPrint + "\n\n" + other.textToPrint;
				tm.name = tm.name + " " + other.name;
				DestroyObject(other.gameObject);
			}
			if (nameIsOk(tm.name)) {
				other = tm;
			}
			i++;
		}
	}

	void Update() {
		if (_story.CurrentPassageName != _currentPassageName) {
			_currentPassageName = _story.CurrentPassageName;
			ChangeExpressionImage(_currentPassageName);
		}
	}
}