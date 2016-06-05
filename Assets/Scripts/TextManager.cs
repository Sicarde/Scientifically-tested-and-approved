using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {
	public bool over = false;
	bool dead = false;
	int charPerLine = 76;
	int nbLines = 3;
	float waitBetweenCharPrint = 1.0f;
	[HideInInspector]
	public string textToPrint;
	Text text;
	string textToAddSlowly = "";
	bool skipText = false;
	bool start = true;
	static int m_UniqueCounter = 0;
	int m_MyID = m_UniqueCounter++;
	ImagesManager _imageManager;

	void Start () {
		if (!nameIsOk(name)) {
			Debug.Log("destroy " + name + " because it's shit");
			dead = true;
			DestroyObject(gameObject);
			return;
		}
		text = gameObject.GetComponentInParent<Text>();
		textToPrint = text.text.Replace('/', '\n');
		_imageManager = GameObject.FindObjectOfType<ImagesManager>();
		//CheckDuplicate();
	}

	int SentenceLenght(string s, int currentSize) {
		string size = s.Substring(0, s.IndexOf(".") + 1);
		int count = (size.Length - size.Replace("\n", "").Length) / 2;
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

/*	void CheckDuplicate() {
		TextManager[] tManager = GameObject.FindObjectsOfType<TextManager>();
		foreach (TextManager tm in tManager) {
			Debug.Log(tm.m_MyID);
			if (tm.m_MyID != m_MyID) {
				if (tm.dead) {
					Debug.Log("tm already dead " + tm.m_MyID + " " + tm.name);
				} else if (dead) {
					Debug.Log("already dead " + m_MyID + " " + name);
				}
			}
			if (tm.m_MyID != m_MyID && !tm.dead && !dead && nameIsOk(tm.name) && nameIsOk(name)) {
				if (m_MyID < tm.m_MyID) {
					textToPrint = textToPrint + tm.textToPrint;
					name = name + " " + tm.name;
					tm.dead = true;
					Debug.Log("destroy " + tm.m_MyID + " " + tm.name + " by " + m_MyID + " " + name);
					DestroyObject(tm.gameObject);
				} else {
					tm.textToPrint = tm.textToPrint + textToPrint;
					tm.name = tm.name + " " + name;
					dead = true;
					Debug.Log("destroy " + m_MyID + " " + name + " by " + tm.m_MyID + " " + tm.name);
					DestroyObject(gameObject);
					return;
				}
			}
		}
	}*/

	IEnumerator UpdateText() {
		//CheckDuplicate();
		_imageManager.CheckTexts();
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

	// Update is called once per frame
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
				return ;
			}
			foreach (string name in _imageManager.characterNames) {
				if (text.text.Contains(name + ":") || text.text.Contains(name + " :")) {
					_imageManager.ChangeCharacterImage(name);
				}
			}
		}
		StartCoroutine(UpdateText());
		CheckOver();
	}
}
