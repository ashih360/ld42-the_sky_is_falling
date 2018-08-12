using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {

    public Text score;

	// Use this for initialization
	void Start () {
        score.text = "Score: " + PlayerPrefs.GetInt("score");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
	}
}
