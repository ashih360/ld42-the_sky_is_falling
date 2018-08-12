using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainEasy : MonoBehaviour {

    public void ToMainScene() {

        SceneManager.LoadScene("Main");
        PlayerPrefs.SetString("difficulty", "easy");
        PlayerPrefs.SetFloat("spawnspeed", 1.0f);
    }
}
