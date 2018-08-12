using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    public float speed;
    public GameObject obj;

	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, 0, speed));
	}

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "Player") {
            Physics.IgnoreCollision(collision.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
        } else {
            obj.SetActive(false);
        }
    }
}
