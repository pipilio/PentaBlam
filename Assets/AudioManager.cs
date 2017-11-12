using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour {

	public static AudioManager instance;
	public AudioClip sample;

	private Dictionary<string, AudioSource> notes;

	private string[] noteNames = new string[] {"C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", "C1"};

	void Awake() {

		if (instance != null) {
			GameObject.Destroy (instance);
		} else {
			instance = this;
		}

		DontDestroyOnLoad (this);
	}

	// Use this for initialization
	void Start () {
		//source = GetComponent<AudioSource> ();
		notes = new Dictionary<string, AudioSource> ();

		for (int i=0; i<13; i++) {
			//AudioClip note = (AudioClip)Instantiate (sample); // this crap didnt work on the device! Find out a proper way of having independent samples
			AudioSource note = gameObject.AddComponent<AudioSource>();
			note.clip = sample;
			note.pitch = Mathf.Pow(1.0594631f, (float)i);
			notes.Add ( noteNames[i], note);
		}
	}

	public void Play(string note) {
		AudioSource source = notes [note];
		source.volume = 1.0f;
		source.PlayOneShot (sample);
	}

	public void CancelPlay(string note) {
		AudioSource source = notes [note];
		StartCoroutine (FadeOut (source));
	}

	public IEnumerator FadeOut(AudioSource source)
	{
		float fadeTime = 0.3f;
		while(fadeTime > 0) {
			source.volume -= (1.0f/0.3f) * Time.deltaTime;
			fadeTime -= Time.deltaTime;
			yield return null;
		}
		yield break;
	}
}
