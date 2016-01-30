using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public GameObject followTarget;

	// Use this for initialization
	void Start () {
		transform.parent = null;
	}
	
	// Update is called once per frame
	void Update () {
		var target = followTarget.transform.position;
		transform.position = new Vector3 (target.x, transform.position.y, target.z);
	}
}
