using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour {

    public CreateFloor createFloor;
    public Transform fallingObject;
    public GameObject fallingObjects;

    private int randomX, randomZ;
    private int max;

    private float interval = 2.75f;
    private int counter = 0;

    private void Start() {
        max = createFloor.floorSize;
        InvokeRepeating("InstantiateObjects", 3, PlayerPrefs.GetFloat("spawnspeed"));
    }

    public void InstantiateObjects() {

        randomX = Random.Range(0, max);
        randomZ = Random.Range(0, max);

        var newFallingObject = Instantiate(fallingObject, new Vector3(randomX, 20, randomZ), new Quaternion(0, 0, 0, 0));
        newFallingObject.transform.parent = fallingObjects.transform;
    }
}
