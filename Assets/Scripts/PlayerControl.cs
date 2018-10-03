﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerControl : MonoBehaviour {

    private Rigidbody playerRb;
    private AudioSource playerWeapon;
    public float speed;
    public float tiltMultiplier;
    public Boundary boundary;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private float nextFire;

    private void Start() {
        playerRb = GetComponent<Rigidbody>();
        playerWeapon = GetComponent<AudioSource>();
    }

    private void Update() {
        if(Input.GetButton("Jump") && Time.time > nextFire){
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            playerWeapon.Play();
        }

    }

    private void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        playerRb.velocity = new Vector3(moveHorizontal * speed, 0.0f, moveVertical * speed);

        playerRb.position = new Vector3(
            Mathf.Clamp(playerRb.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(playerRb.position.z, boundary.zMin, boundary.zMax)
        );

        playerRb.rotation = Quaternion.Euler(0.0f, 0.0f, -playerRb.velocity.x * tiltMultiplier);
    }
}
