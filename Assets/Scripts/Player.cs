using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

	public float speed = 1.0f;
	public GameObject cursor;
	public GameObject bomb;


	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		var cur = cursor.transform;
		var cursorXpos = cur.localPosition.x + Input.GetAxis ("Mouse X") * 0.5f;
		var cursorZpos = cur.localPosition.z + Input.GetAxis ("Mouse Y") * 0.5f;
		cur.localPosition = new Vector3 (cursorXpos, 0, cursorZpos).normalized * 1.25f;

		if (Input.GetKeyDown(KeyCode.Mouse0)) {
			var obj = Instantiate(bomb, cursor.transform.position, Quaternion.identity) as GameObject;
			obj.GetComponent<Rigidbody> ().velocity = new Vector3 (cur.localPosition.x, 0, cur.localPosition.z) * 10.0f;
		}
	}

	void FixedUpdate ()
	{
		var movDelta = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical")) * speed;
		var t = this.GetComponent<Transform> ();
		t.Translate (movDelta);
	}


}
