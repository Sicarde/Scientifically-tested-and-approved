using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ImagesManager : MonoBehaviour {
	public GameObject characterImageTemplate;
	public GameObject expressionImageTemplate;

	public List<Sprite> characters;
	public List<string> indexOfCharacterAndPassageNameForCharacterChange;
	public List<Sprite> charactersExpression;
	public List<string> indexOfExpressionAndPassageNameForExpressionChange;

	string _currentPassageName = "";
	Story _story;

	void Start() {
		_story = GameObject.FindObjectOfType<Story>();
	}

	public void ChangeCharacterImage(string passageName) {
		foreach (string s in indexOfCharacterAndPassageNameForCharacterChange) {
			if (s.Contains(passageName)) {
				characterImageTemplate.GetComponent<Image>().sprite = characters[int.Parse(s.Substring(0, s.IndexOf(" ")))];
			}
		}
	}
	
	public void ChangeExpressionImage(string passageName) {
		foreach (string s in indexOfExpressionAndPassageNameForExpressionChange) {
			if (s.Contains(passageName)) {
				expressionImageTemplate.GetComponent<Image>().sprite = charactersExpression[int.Parse(s.Substring(0, s.IndexOf(" ")))];
			}
		}
	}

	void Update() {
		if (_story.CurrentPassageName != _currentPassageName) {
			_currentPassageName = _story.CurrentPassageName;
			ChangeCharacterImage(_currentPassageName);
			ChangeExpressionImage(_currentPassageName);
		}
	}
}