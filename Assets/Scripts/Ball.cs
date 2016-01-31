using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{

	private Vector3 origLocation;
	private GameObject[] floors;
	// Use this for initialization
	void Start ()
	{
		this.origLocation = this.transform.localPosition;
		Physics.IgnoreLayerCollision (8, 9);
		floors = GameObject.FindGameObjectsWithTag ("floor");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (transform.position.y < -50.0f) {
			this.Reset();
		}

		if (transform.position.y > origLocation.y + 0.1f) {
			var rb = gameObject.GetComponent<Rigidbody> ();
			rb.velocity = new Vector3 (rb.velocity.x, 0, rb.velocity.z);
		}

		if (Input.GetKeyDown (KeyCode.R)) {
			this.Reset ();
		}
	}

	public void Reset ()
	{
		this.transform.localPosition = origLocation;
		GetComponent<Rigidbody> ().velocity = Vector3.zero;
		GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;
		for (int i = 0; i < floors.Length; i++) {
			Physics.IgnoreCollision(floors[i].GetComponent<Collider>(), GetComponent<Collider>(), false);
		}
		
	}
}
