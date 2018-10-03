using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour {

    public float time;

	void Start () {
        Destroy(gameObject, time);
	}
}
