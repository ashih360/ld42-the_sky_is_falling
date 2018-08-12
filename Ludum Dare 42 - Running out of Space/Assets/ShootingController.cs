using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour {

    public Transform bullet;
    public GameObject playerY;
    public GameObject playerX;

    public void Update() {
        if(Input.GetMouseButtonDown(0)) {
            Fire();
        }
    }

    private void Fire() {
        Instantiate(bullet, playerX.transform.position, playerX.transform.rotation);
    }
}
