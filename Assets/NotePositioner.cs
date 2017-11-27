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
    public GameObject mainPanel;
	public GameObject[] spaces;
	public GameObject[] lines;

    private GameObject nota;

    public GameObject GetNota()
    {
        return nota;
    }

	public const int noteHeight = 70;

	public void ShowNote(string noteName, float ttl)
	{
        nota = Object.Instantiate<GameObject>(note);
        nota.GetComponent<NoteController>().SetTtl(ttl);

        switch (noteName) {
			case "C":
				nota.GetComponent<NoteController>().MakeNatural();
				nota.transform.SetParent(lines[0].transform, false);
				break;
			case "C#":
				nota.GetComponent<NoteController>().MakeSharp();
				nota.transform.SetParent(lines[0].transform, false);
				break;
			case "D":
				nota.GetComponent<NoteController>().MakeNatural();
				nota.transform.SetParent(spaces[0].transform, false);
				break;
			case "D#":
				nota.GetComponent<NoteController>().MakeSharp();
				nota.transform.SetParent(spaces[0].transform, false);
				break;
			case "E":
				nota.GetComponent<NoteController>().MakeNatural();
				nota.transform.SetParent(lines[1].transform, false);
				break;
			case "F":
				nota.GetComponent<NoteController>().MakeNatural();
				nota.transform.SetParent(spaces[1].transform, false);
				break;
			case "F#":
				nota.GetComponent<NoteController>().MakeSharp();
				nota.transform.SetParent(spaces[1].transform, false);
				break;
			case "G":
				nota.GetComponent<NoteController>().MakeNatural();
				nota.transform.SetParent(lines[2].transform, false);
				break;
			case "G#":
				nota.GetComponent<NoteController>().MakeSharp();
				nota.transform.SetParent(lines[2].transform, false);
				break;
			case "A":
				nota.GetComponent<NoteController>().MakeNatural();
				nota.transform.SetParent(spaces[2].transform, false);
				break;
			case "A#":
				nota.GetComponent<NoteController>().MakeSharp();
				nota.transform.SetParent(spaces[2].transform, false);
				break;
			case "B":
				nota.GetComponent<NoteController>().MakeNatural();
				nota.transform.SetParent(lines[3].transform, false);
				break;
			case "C1":
				nota.GetComponent<NoteController>().MakeNatural();
				nota.transform.SetParent(spaces[3].transform, false);
				break;
			default:
				break;
				//note.SetActive(false);
		}
        nota.GetComponent<NoteController>().Configure();
        nota.GetComponent<NoteController>().movable = true;


    }

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
