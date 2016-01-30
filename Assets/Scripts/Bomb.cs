using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<Rigidbody> ().velocity.magnitude < 1) {
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.GetComponent<Ball>() != null) {
			Destroy (this.gameObject);
		}
	}
}
