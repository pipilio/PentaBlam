using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public Text lifeLabel;
	public Text streakLabel;

	private string notePressed;

	void Awake() {
		if (instance != null) {
			GameObject.Destroy (instance);
		} else {
			instance = this;
		}
		
		DontDestroyOnLoad (this);
	}

	System.Random rand = new System.Random();
	private int _lives;
	public int lives 
	{
		set
		{
			_lives = value;
			lifeLabel.text = value.ToString();
		}
		get
		{
			return _lives;
		}
	}

	private int _streak;
	public int streak
	{
		set
		{
			_streak = value;
			streakLabel.text = value.ToString();
		}
		get
		{
			return _streak;
		}
	}

	private const float ttl = 3.0f;
	private string[] noteNames = new string[] {"C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", "C1"};
	private string currentNoteName;


	// Use this for initialization
	void Start () {
		lives = 10;
		streak = 0;
		StartCoroutine (MainCycle());
	}
	

	public void OnNotePressed(string noteName)
	{
		if (notePressed.Equals("")) {
			notePressed = noteName;
			if (noteName != currentNoteName) {
				Debug.Log ("you fucker!");
				lives--;
				streak = 0;
			} else {
				Debug.Log ("good");
				streak++;
			}
		}
	}

	public IEnumerator MainCycle()
	{
		while (lives > 0) {
			notePressed = "";
			int nextNoteIndex = rand.Next () % noteNames.Length;
			string nextNote = noteNames [nextNoteIndex];
			currentNoteName = nextNote;
			Debug.Log ("selected note is " + nextNote);
			NotePositioner.instance.ShowNote (nextNote);
			yield return new WaitForSeconds(ttl);
			if (!notePressed.Equals (nextNote)) {
				lives--;
				streak = 0;
			}
		}
		yield break;
	}
	
}
