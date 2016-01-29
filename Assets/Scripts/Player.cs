using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

	public float speed = 1.0f;


	// Use this for initialization
	void Start ()
	{
		
	}

	// Update is called once per frame
	void Update ()
	{
		
	}

	void FixedUpdate ()
	{
		var movDelta = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical")) * speed;
		var t = this.GetComponent<Transform> ();
		t.Translate (movDelta);
	}


}
