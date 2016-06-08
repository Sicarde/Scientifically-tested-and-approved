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
	public List<string> expressionNames;

	public GameObject backgroundImageTemplate;
	public List<Sprite> backgrounds;
	public List<string> backgroundPassageUsed;

	[HideInInspector]
	public string currentDisplayedCharacter = "";
	private Image _characterImage;
	private Image _expressionImage;
	Story _story;
	string _currentPassageName = "";

	void Start() {
		_characterImage = characterImageTemplate.GetComponent<Image>();
		_expressionImage = expressionImageTemplate.GetComponent<Image>();
		DisableCharacterImage();
		_story = GameObject.FindObjectOfType<Story>();
	}

	void FadeIn() {
		//_characterImage;
		//_expressionImage;
	}

	void EnableCharacterImage() {
		_characterImage.enabled = true;
		_expressionImage.enabled = true;
	}

	void DisableCharacterImage() {
		_characterImage.enabled = false;
		_expressionImage.enabled = false;
	}

	public void ChangeCharacterImage(string characterName) {
		int i = 0;
		foreach (string s in characterNames) {
			if (s.Contains(characterName)) {
				EnableCharacterImage();
				_characterImage.sprite = characters[i];
				currentDisplayedCharacter = s;
				ChangeExpressionImage("", currentDisplayedCharacter);
				return;
			}
			i++;
		}
	}
	
	public void ChangeExpressionImage(string expressionName, string characterName) {
		if (characterName.Length <= 0) {
			characterName = currentDisplayedCharacter;
		}
		int i = 0;
		foreach (string s in expressionNames) {
			if (s.Contains(expressionName) && s.Contains(characterName)) {
				_expressionImage.sprite = charactersExpression[i];
				return;
			}
			i++;
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
			if (i > 0 && nameIsOk(tm.name) && nameIsOk(name) && tm && other) {
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

	void UpdateBackground() {
		int i = 0;
		foreach (string passageUsedName in backgroundPassageUsed) {
			if (_currentPassageName == passageUsedName) {
				backgroundImageTemplate.GetComponent<Image>().sprite = backgrounds[i];
			}
			i++;
		}
	}

	void Update() {
		if (_story.CurrentPassageName != _currentPassageName) {
			_currentPassageName = _story.CurrentPassageName;
			DisableCharacterImage();
			UpdateBackground();
		}
	}
}