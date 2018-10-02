using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt : MonoBehaviour {

    Rigidbody rbBolt;
    public float speed;

    private void Start() {
        rbBolt = GetComponent<Rigidbody>();
        rbBolt.velocity = transform.forward * speed;
    }
}
