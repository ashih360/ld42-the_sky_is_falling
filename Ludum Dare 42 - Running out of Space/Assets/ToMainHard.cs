using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainHard : MonoBehaviour {

    public void ToMainScene() {

        SceneManager.LoadScene("Main");
        PlayerPrefs.SetString("difficulty", "hard");
        PlayerPrefs.SetFloat("spawnspeed", 0.75f);
    }
}
