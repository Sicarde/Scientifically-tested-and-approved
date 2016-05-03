using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {
	public bool over = false;
	bool dead = false;
	int charPerLine = 47;
	int nbLines = 4;
	float waitBetweenCharPrint = 1.0f;
	string textToPrint;
	Text text;
	string textToAddSlowly = "";
	bool skipText = false;
	bool start = true;
	static int m_UniqueCounter = 0;
	int m_MyID = m_UniqueCounter++;

	void Start () {
		if (name == "" || name == "(empty line)") {
			DestroyObject(gameObject);
			return;
		}
		text = gameObject.GetComponentInParent<Text>();
		TextManager[] tManager = GameObject.FindObjectsOfType<TextManager>();
		if (tManager.Length > 1) {
			foreach (TextManager tm in tManager) {
				if (tm.m_MyID != m_MyID && !tm.dead) {
					textToPrint = text.text.Replace('/', '\n') + tm.textToPrint;
					name = name + " " + tm.name;
					tm.dead = true;
					DestroyObject(tm.gameObject);
					return;
				}
			}
		} else {
			textToPrint = text.text.Replace('/', '\n');
		}
		textToPrint = text.text.Replace('/', '\n');
		if (textToPrint.Length == 0) {
			gameObject.SetActive(false);
		}
	}

	int SentenceLenght(string s, int currentSize) {
		string size = s.Substring(0, s.IndexOf(".") + 1);
		int count = (size.Length - size.Replace("\n", "").Length) / 2;
		if (s.IndexOf(".") != -1 && s.IndexOf(".") + currentSize + count * charPerLine < charPerLine * nbLines) {
			return (s.IndexOf(".") + 1);
		}
		if (s.IndexOf(",") != -1 && s.IndexOf(",") + currentSize + count * charPerLine < charPerLine * nbLines) {
			return (s.IndexOf(",") + 1);
		}
		if (s.IndexOf("\n") != -1 && s.IndexOf("\n") + currentSize + count * charPerLine < charPerLine * nbLines) {
			return (s.IndexOf("\n") + 1);
		}
		return s.Length;
	}

	string GetSentence(ref string s, int lenght) {
		string sentence = s.Substring(0, SentenceLenght(s, lenght));
		s = s.Substring(sentence.Length);
		return sentence;
	}

	string SaveTextOverflow(string newText) {
		string replacmentText = "";
		if (textToPrint.Length > 0) {
			while (textToPrint.Length > 0 && (replacmentText.Length + SentenceLenght(textToPrint, replacmentText.Length)) < charPerLine * nbLines) {
				replacmentText += GetSentence(ref textToPrint, replacmentText.Length);
			}
			while (newText.Length > 0 && (replacmentText.Length + SentenceLenght(newText, replacmentText.Length)) < charPerLine * nbLines) {
				replacmentText += GetSentence(ref newText, replacmentText.Length);
			}
			textToPrint += newText;
			return replacmentText;
		} else {
			while (newText.Length > 0 && (replacmentText.Length + SentenceLenght(newText, replacmentText.Length)) < charPerLine * nbLines) {
				replacmentText += GetSentence(ref newText, replacmentText.Length);
			}
			textToPrint = newText;
			return replacmentText;
		}
	}

	IEnumerator UpdateText() {
		while (text.text.Length > 0 && text.text[0] == '\n') {
			text.text = text.text.Substring(1, text.text.Length - 1);
		}
		while (textToAddSlowly.Length > 0) {
			text.text += textToAddSlowly[0];
			textToAddSlowly = textToAddSlowly.Substring(1, textToAddSlowly.Length - 1);
			yield return(new WaitForSeconds(waitBetweenCharPrint));
		}
	}

	void CheckOver() {
		if (!dead && textToPrint.Length == 0 && textToAddSlowly.Length == 0 && !over) {
			over = true;
			LinkManager[] linksManagers = GameObject.FindObjectsOfType<LinkManager>();
			int i = 0;
			foreach (LinkManager lm in linksManagers) {
				lm.EnableLink();
				lm.transform.localPosition = new Vector3(lm.transform.localPosition.x,
				                                         lm.transform.localPosition.y - 45 * i,
				                                         lm.transform.localPosition.z);
				i++;
			}
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
		CheckOver();
	}
}
