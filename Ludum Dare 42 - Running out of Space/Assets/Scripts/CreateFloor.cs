using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFloor : MonoBehaviour {

    public GameObject Floor;
    public Transform floor;
    public int floorSize, layers;
    public float gap;

	void Start () {
        for (int l = 0; l < layers; l++) {
            for (int i = 0; i < floorSize; i++) {
                for (int j = 0; j < floorSize; j++) {

                    if(PlayerPrefs.GetString("difficulty") == "easy") {
                        Transform newFloor = Instantiate(floor, new Vector3(i + gap * i, l + gap * l, j + gap * j), new Quaternion(0, 0, 0, 0));
                        newFloor.transform.parent = Floor.transform;
                        newFloor.GetComponent<Rigidbody>().isKinematic = true;
                    }
                    if (PlayerPrefs.GetString("difficulty") == "hard") {
                        Transform newFloor = Instantiate(floor, new Vector3(i + gap * i, l + gap * l, j + gap * j), new Quaternion(0, 0, 0, 0));
                        newFloor.transform.parent = Floor.transform;
                        newFloor.GetComponent<Rigidbody>().isKinematic = false;
                    }
                }
            }
        }
	}
}
