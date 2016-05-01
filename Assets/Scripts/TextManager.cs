using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {
	public bool over = false;
	int charPerLine = 53;
	int nbLines = 5;
	float waitBetweenCharPrint = 1.0f;
	string textToPrint;
	Text text;
	string textToAddSlowly = "";
	bool skipText = false;
	bool start = true;

	// Use this for initialization
	void Start () {
		text = gameObject.GetComponentInParent<Text>();
		textToPrint = text.text.Replace('/', '\n');
		if (textToPrint.Length == 0) {
			gameObject.SetActive(false);
		}
	}

	int SentenceLenght(string s) {
		if (s.IndexOf(".") != -1) {
			if (s.IndexOf(".") < charPerLine * nbLines) {
				return (s.IndexOf(".") + 1);
			}
		}
		if (s.IndexOf(",") != -1)
			return (s.IndexOf(",") + 1);
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
		if (Input.anyKeyDown || start) {
			if (start) {
				start = false;
			}
			if (textToAddSlowly.Length > 0) {
				skipText = true;
			} else {
				if (textToPrint.Length == 0 && textToAddSlowly.Length == 0 && !over) {
					over = true;
					LinkManager[] linksManagers = GameObject.FindObjectsOfType<LinkManager>();
					int i = 0;
					foreach (LinkManager lm in linksManagers) {
						lm.EnableLink();
						lm.transform.localPosition = new Vector3(lm.transform.localPosition.x,
						                                             lm.transform.localPosition.y - 50 * i,
						                                             lm.transform.localPosition.z);
						i++;
					}
				}
				textToAddSlowly = SaveTextOverflow("");
				if (textToAddSlowly.Length > 0) {
					text.text = "";
					if (textToAddSlowly[0] == ' ') {
						textToAddSlowly = textToAddSlowly.Substring(1);
					}
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
