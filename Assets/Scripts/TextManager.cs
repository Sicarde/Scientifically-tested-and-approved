using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {
	public bool over = false;
	bool dead = false;
	int charPerLine = 76;
	int nbLines = 4;
	float waitBetweenCharPrint = 1.0f;
	[HideInInspector]
	public string textToPrint;
	Text text;
	string textToAddSlowly = "";
	bool skipText = false;
	bool start = true;
	ImagesManager _imageManager;

	void Start () {
		if (!nameIsOk(name)) {
			dead = true;
			DestroyObject(gameObject);
			return;
		}
		text = gameObject.GetComponentInParent<Text>();
		textToPrint = text.text.Replace('/', '\n');
		while (textToPrint.EndsWith("\n")) {
			textToPrint.Substring(0, textToPrint.Length - 2);
		}
		text.text = textToPrint;
		_imageManager = GameObject.FindObjectOfType<ImagesManager>();
	}

	int SentenceLenght(string s, int currentSize) {
		string size = s.Substring(0, s.IndexOf(".") + 1);
		float count = (size.Length - size.Replace("\n", "").Length) / 1.25f;
		if (s.IndexOf("\"") != -1 && s.IndexOf("\"") + currentSize + count * charPerLine < charPerLine * nbLines) {
			return (s.IndexOf("\"") + 1);
		}
		if (s.IndexOf(".") != -1 && s.IndexOf(".") + currentSize + count * charPerLine < charPerLine * nbLines) {
			return (s.IndexOf(".") + 1);
		}
		if (s.IndexOf(",") != -1 && s.IndexOf(",") + currentSize + count * charPerLine < charPerLine * nbLines) {
			return (s.IndexOf(",") + 1);
		}
		if (s.IndexOf("?") != -1 && s.IndexOf("?") + currentSize + count * charPerLine < charPerLine * nbLines) {
			return (s.IndexOf("?") + 1);
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

	bool nameIsOk(string name) {
		return (name != "" && name != "(empty line)" && name != "/" && name != "//");
	}

	IEnumerator UpdateText() {
		if (!_imageManager) {
			_imageManager = GameObject.FindObjectOfType<ImagesManager>();
		}
		_imageManager.CheckTexts();
		while (text.text.Length > 0 && text.text[0] == '\n') {
			text.text = text.text.Substring(1, text.text.Length - 1);
		}
		while (textToAddSlowly.Length > 0) {
			text.text += textToAddSlowly[0];
			textToAddSlowly = textToAddSlowly.Substring(1, textToAddSlowly.Length - 1);
			UpdateCharacterDisplayed();
			yield return(new WaitForSeconds(waitBetweenCharPrint));
		}
	}

	bool CheckEmpty(string s) {
		if (s.Length == 0) {
			return true;
		}
		s = s.Replace(" ", string.Empty);
		s = s.Replace("\t", string.Empty);
		s = s.Replace("\n", string.Empty);
		if (s.Length > 0) {
			return false;
		} else {
			return true;
		}
	}

	void CheckOver() {
		if (!dead && CheckEmpty(textToPrint) && CheckEmpty(textToAddSlowly) && !over) {
			over = true;
			Debug.Log("over");
			LinkManager[] linksManagers = GameObject.FindObjectsOfType<LinkManager>();
			int i = 0;
			foreach (LinkManager lm in linksManagers) {
				if (!lm.HasBeenEnabled()) {
					lm.EnableLink();
					lm.transform.localPosition = new Vector3(lm.transform.localPosition.x,
				    	                                     lm.transform.localPosition.y - 45 * i,
				        	                                 lm.transform.localPosition.z);
				}
				i++;
			}
		}
	}

	void UpdateCharacterDisplayed() {
		foreach (string name in _imageManager.characterNames) {
			if (text.text.Contains(name + ":") || text.text.Contains(name + " :")) {
				_imageManager.ChangeCharacterImage(name);
			}
		}
	}

	void Update () {
		if ((Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Escape)) || start) {
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
				UpdateCharacterDisplayed();
				return ;
			}
		}
		StartCoroutine(UpdateText());
		CheckOver();
	}
}
