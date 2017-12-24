using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderController : MonoBehaviour {

    public Sprite[] sprites;

    private int spriteIndex = 0;
    private float changeSpriteTime = 0.1f;
    private float currentSpriteTime = 0f;

	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[spriteIndex];
	}

	// Update is called once per frame
	void Update () {
        currentSpriteTime += Time.deltaTime;
        if (currentSpriteTime >= changeSpriteTime)
        {
            spriteIndex = (spriteIndex + 1) % sprites.Length;
            currentSpriteTime = 0f;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[spriteIndex];
        }

    }
}
