using UnityEngine;
using System.Collections;

public class NoteController : MonoBehaviour {

	public GameObject modifier;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MakeSharp()
	{
		modifier.SetActive (true);
	}

	public void MakeNatural()
	{
		modifier.SetActive (false);
	}
}
