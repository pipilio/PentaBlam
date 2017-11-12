using UnityEngine;
using System.Collections;

public class NoteController : MonoBehaviour {

	public GameObject modifier;
    public bool movable;

    private float timeAlive;
    private float ttl;
    private float length;

    public void SetTtl(float ttl)
    {
        this.ttl = ttl;
    }

	// Use this for initialization
	void Start () {
        timeAlive = 0f;
        length = this.GetComponent<Transform>().parent.GetComponent<RectTransform>().rect.width;
    }

    public void Configure()
    {
        Vector3 pos = this.GetComponent<Transform>().localPosition;
        Vector2 anchor = this.GetComponent<RectTransform>().anchoredPosition;
        this.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, anchor.y);
    }

	// Update is called once per frame
	void Update () {
        if (!movable)
        {
            return;
        }
        timeAlive += Time.deltaTime;
        Vector2 anchor = this.GetComponent<RectTransform>().anchoredPosition;
        this.GetComponent<RectTransform>().anchoredPosition = new Vector2(-length * timeAlive / ttl, anchor.y);
        if (timeAlive > ttl)
        {
            GameManager.instance.OnNoteExpired();
            GameObject.Destroy(this.gameObject);
        }
    }

    public void ageNote(float time)
    {
        timeAlive += time;
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
