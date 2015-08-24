using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NotePositioner : MonoBehaviour {

	public static NotePositioner instance;

	void Awake() {
		
		if (instance != null) {
			GameObject.Destroy (instance);
		} else {
			instance = this;
		}
		
		DontDestroyOnLoad (this);
	}

	public GameObject note;
	public GameObject[] spaces;
	public GameObject[] lines;

	public const int noteHeight = 70;

	public void ShowNote(string noteName)
	{
		//note.SetActive (true);
		switch (noteName) {
			case "C":
				note.GetComponent<NoteController>().MakeNatural();
				note.transform.SetParent(lines[0].transform, false);
				break;
			case "C#":
				note.GetComponent<NoteController>().MakeSharp();
				note.transform.SetParent(lines[0].transform, false);
				break;
			case "D":
				note.GetComponent<NoteController>().MakeNatural();
				note.transform.SetParent(spaces[0].transform, false);
				break;
			case "D#":
				note.GetComponent<NoteController>().MakeSharp();
				note.transform.SetParent(spaces[0].transform, false);
				break;
			case "E":
				note.GetComponent<NoteController>().MakeNatural();
				note.transform.SetParent(lines[1].transform, false);
				break;
			case "F":
				note.GetComponent<NoteController>().MakeNatural();
				note.transform.SetParent(spaces[1].transform, false);
				break;
			case "F#":
				note.GetComponent<NoteController>().MakeSharp();
				note.transform.SetParent(spaces[1].transform, false);
				break;
			case "G":
				note.GetComponent<NoteController>().MakeNatural();
				note.transform.SetParent(lines[2].transform, false);
				break;
			case "G#":
				note.GetComponent<NoteController>().MakeSharp();
				note.transform.SetParent(lines[2].transform, false);
				break;
			case "A":
				note.GetComponent<NoteController>().MakeNatural();
				note.transform.SetParent(spaces[2].transform, false);
				break;
			case "A#":
				note.GetComponent<NoteController>().MakeSharp();
				note.transform.SetParent(spaces[2].transform, false);
				break;
			case "B":
				note.GetComponent<NoteController>().MakeNatural();
				note.transform.SetParent(lines[3].transform, false);
				break;
			case "C1":
				note.GetComponent<NoteController>().MakeNatural();
				note.transform.SetParent(spaces[3].transform, false);
				break;
			default:
				break;
				//note.SetActive(false);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
