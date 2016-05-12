using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour {

	public Story storyScript;
	public AudioClip[] voiceClips;

	private string currentName;

	// Use this for initialization
	void Awake () {
		AudioSource source = this.gameObject.GetComponent<AudioSource> ();
		//voiceClips = Resources.Load ("Sounds/Voices") as AudioClip[];

		currentName = storyScript.CurrentPassageName;
		print(currentName);

		foreach (AudioClip a in voiceClips) {
			print (a.name);
			if (a.name == currentName){
				source.clip = a;
				source.Play ();
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
