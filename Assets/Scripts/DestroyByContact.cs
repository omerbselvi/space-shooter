using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    public GameObject explosion;
    public GameObject playerExplosion;

    private void OnTriggerEnter(Collider other) {
        if(other.tag != "Boundary"){
            Instantiate(explosion, transform.position, transform.rotation);
            if(other.tag == "Player"){
                Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            }
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
