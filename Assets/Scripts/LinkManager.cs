using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LinkManager : MonoBehaviour {
	[HideInInspector]
	public TextManager _textManager;
	public bool _isVisible = false;
	Button _button;
	Text _text;

	// Use this for initialization
	void Start () {
		_button = GetComponent<Button>();
		_text = _button.GetComponentInChildren<Text>();
		_button.enabled = false;
		_text.enabled = false;
	}

	public bool HasBeenEnabled() {
		return (_isVisible && _text.enabled && _button.enabled);
	}

	public void EnableLink() {
		_button.enabled = true;
		_text.enabled = true;
		_isVisible = true;
	}
}
