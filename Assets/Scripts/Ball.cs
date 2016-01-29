﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{

	private Vector3 origLocation;

	// Use this for initialization
	void Start ()
	{
		this.origLocation = this.transform.localPosition;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (transform.position.y < -50.0f) {
			this.Reset();
		}
	}

	public void Reset ()
	{
		this.transform.localPosition = origLocation;
		GetComponent<Rigidbody> ().velocity = Vector3.zero;
		GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;
		Physics.IgnoreCollision(GetComponent<Collider>(), GameObject.FindWithTag("world").GetComponent<Collider>(), false);
	}
}
