using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMain : MonoBehaviour {

    public void ToMainScene() {
        
        SceneManager.LoadScene("DifficultySelect");
        PlayerPrefs.SetInt("score", 0);
    }
}
