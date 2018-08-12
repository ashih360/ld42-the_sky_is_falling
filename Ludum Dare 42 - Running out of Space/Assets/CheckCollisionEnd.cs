using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckCollisionEnd : MonoBehaviour {

    public GameObject obj;

    private void OnCollisionEnter(Collision collision) {

        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.name == "Player") {
            obj.SetActive(false);
            SceneManager.LoadScene("Lost");
        }
    }
}
