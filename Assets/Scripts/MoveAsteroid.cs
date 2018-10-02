using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAsteroid : MonoBehaviour {

    Rigidbody rbAsteroid;
    public float speed;

    private void Start() {
        rbAsteroid = GetComponent<Rigidbody>();
        rbAsteroid.velocity = transform.forward * speed;
    }
}
