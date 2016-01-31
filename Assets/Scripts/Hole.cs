using UnityEngine;
using System.Collections;

public class Hole : MonoBehaviour {

	public GameObject light;
	public GameObject door;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col) {
		var obj = col.gameObject;
		if (obj.GetComponent<Ball>() != null) {
			obj.GetComponent<Rigidbody> ().velocity = Vector3.zero;
			foreach (GameObject floor in GameObject.FindGameObjectsWithTag("floor")) {
				Physics.IgnoreCollision (obj.GetComponent<Collider> (), floor.GetComponent<Collider> (), true);
			}
			light.GetComponent<Light> ().color = Color.green;
			door.SetActive (true);
		}
	}
}
