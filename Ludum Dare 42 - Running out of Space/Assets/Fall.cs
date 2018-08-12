using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour {

    public float speed;
    public GameObject obj;

    // Update is called once per frame
    void Update () {
        transform.Translate(new Vector3(0, speed, 0));
	}
}
