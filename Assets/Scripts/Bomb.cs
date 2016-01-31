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
			var obj = col.gameObject;
			obj.GetComponent<Rigidbody> ().AddForce (GetComponent<Rigidbody> ().velocity.normalized * 250);
			GetComponent<Collider> ().enabled = false;
			foreach (Renderer r in GetComponentsInChildren<Renderer>()) {
				r.enabled = false;
			}
			var audio = GetComponent<AudioSource> ();
			audio.PlayOneShot (audio.clip);
			Destroy (this.gameObject, audio.clip.length);
		}
	}
}
