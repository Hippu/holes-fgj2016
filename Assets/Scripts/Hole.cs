using UnityEngine;
using System.Collections;

public class Hole : MonoBehaviour {

	public GameObject worldMesh;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col) {
		var obj = col.gameObject;
		if (obj.GetComponent<Ball>() != null) {
			Physics.IgnoreCollision (worldMesh.GetComponent<Collider> (), obj.GetComponent<Collider> ());
			// obj.GetComponent<Ball>().Reset();
		}
	}
}
