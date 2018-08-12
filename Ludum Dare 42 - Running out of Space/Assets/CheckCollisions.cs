using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisions : MonoBehaviour {

    public GameObject obj;

    private void OnCollisionEnter(Collision collision) {

        //Debug.Log(collision.gameObject.name);

        if(collision.gameObject.name == "FallingObject(Clone)") {
            obj.SetActive(false);
        }

        if (collision.gameObject.name == "Bullet(Clone)") {
            obj.SetActive(false);
        }
    }
}
