using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallObjCheckCollisions : MonoBehaviour {

    public GameObject obj;
    public ScoreManager scoreManager;

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Bullet(Clone)") {
            obj.SetActive(false);
            int score = PlayerPrefs.GetInt("score");
            score++;
            PlayerPrefs.SetInt("score", score);
        }
        if (collision.gameObject.name == "Floor(Clone)") {
            obj.SetActive(false);
        }
    }
}
