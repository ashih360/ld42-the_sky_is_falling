using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 10;
    public float jumpHeight = 300;
    Rigidbody rb;
    private bool isJumping;

	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	void Update () {
        float movev = Input.GetAxis("Vertical") * speed;
        float moveh = Input.GetAxis("Horizontal") * speed;

        moveh *= Time.deltaTime;
        movev *= Time.deltaTime;

        transform.Translate(moveh, 0, movev);

        if(!isJumping) {
            if(Input.GetKey(KeyCode.Space)) {
                rb.AddForce(0, jumpHeight, 0);
                isJumping = true;
            }
        }
	}

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Floor(Clone)") {
            isJumping = false;
        }
    }
}
