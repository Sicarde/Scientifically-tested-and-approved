using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {
	int charPerLine = 53;
	int nbLines = 5;
	float waitBetweenCharPrint = 1.0f;
	string textToPrint;
	Text text;
	string textToAddSlowly = "";
	bool skipText = false;

	// Use this for initialization
	void Start () {
		text = gameObject.GetComponentInParent<Text>();
		textToPrint = "ceci est un merveilleux test. en experant que ca marche sinon. ca serait plutot genant test. en experant que ca. ma ceci est un merveilleux test. en experant que ca marche sinon. ca serait plutot genant test. en experant que ca. marche sinon ca. serait plutot. genant test en experant. que ca marche. sinon ca serait. plutot genant test en. experant que ca marche. sinon ca serait plutot genant ceci. est un plop plop plop. test en experant que. ca marche sinon ca serait. plutot genant test en experant. que ca marche sinon ca. serait plutot genant test en experant que. ca marche sinon ca serait plutot genant. test en experant que ca. marche sinon ca serait plutot. genant ceci est un. merveilleux test en experant que ca. marche sinon ca serait plutot genant test en experant. que ca marche sinon ca serait plutot. genant test en experant que ca marche sinon ca serait plutot genant test en experant que ca marche sinon ca serait plutot genant FIN DU TEXTE.";
	}

	int SentenceLenght(string s) {
		if (s.IndexOf(".") != -1)
			return (s.IndexOf(".") + 1);
		return s.Length;
	}
	
	string GetSentence(ref string s) {
		string sentence = s.Substring(0, SentenceLenght(s));
		s = s.Substring(sentence.Length);
		return sentence;
	}

	string SaveTextOverflow(string newText) {
		string replacmentText = "";
		if (textToPrint.Length > 0) {
			while (textToPrint.Length > 0 && (replacmentText.Length + SentenceLenght(textToPrint)) < charPerLine * nbLines) {
				replacmentText += GetSentence(ref textToPrint);
			}
			while (newText.Length > 0 && (replacmentText.Length + SentenceLenght(newText)) < charPerLine * nbLines) {
				replacmentText += GetSentence(ref newText);
			}
			textToPrint += newText;
			return replacmentText;
		} else {
			Debug.Log("over");
			while (newText.Length > 0 && (replacmentText.Length + SentenceLenght(newText)) < charPerLine * nbLines) {
				replacmentText += GetSentence(ref newText);
			}
			textToPrint = newText;
			return replacmentText;
		}
	}

	IEnumerator UpdateText() {
		while (textToAddSlowly.Length > 0) {
			text.text += textToAddSlowly[0];
			textToAddSlowly = textToAddSlowly.Substring(1, textToAddSlowly.Length - 1);
			yield return(new WaitForSeconds(waitBetweenCharPrint));
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			if (textToAddSlowly.Length > 0) {
				skipText = true;
			} else {
				textToAddSlowly = SaveTextOverflow("");
				if (textToAddSlowly.Length > 0) {
					text.text = "";
				}
			}
			if (skipText) {
				text.text += textToAddSlowly;
				textToAddSlowly = "";
				skipText = false;
				return ;
			}
		}
		StartCoroutine(UpdateText());
	}
}
