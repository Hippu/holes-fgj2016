﻿using UnityEngine;
using System.Collections;

public class Hole : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col) {
		var obj = col.gameObject;
		if (obj.GetComponent<Ball>() != null) {
			obj.GetComponent<Ball>().Reset();
		}
	}
}
