using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

	public float speed = 1.0f;
	public GameObject cursor;
	public GameObject bomb;
	public bool canBomb;


	// Use this for initialization
	void Start ()
	{
		if (!canBomb) {
			GameObject.Find ("cursor").SetActive (false);
		}
		cursor.transform.parent = null;
	}

	// Update is called once per frame
	void Update ()
	{
		var cur = cursor.transform;
		var cursorpos = transform.InverseTransformPoint (cur.position);
		cursorpos.x = cursorpos.x + Input.GetAxis ("Mouse X") * 0.2f;
		cursorpos.z = cursorpos.z + Input.GetAxis ("Mouse Y") * 0.2f;
		var loc_cursorpos  = new Vector3 (cursorpos.x, 0, cursorpos.z).normalized;
		var world_cursorpos = transform.TransformPoint (loc_cursorpos);
		cur.position = world_cursorpos;

		if (GetComponent<Rigidbody> ().velocity.sqrMagnitude < 0.000005f) {
			transform.LookAt (cur);
		}

		if (Input.GetKeyDown(KeyCode.Mouse0) && canBomb) {
			var obj = Instantiate(bomb, cursor.transform.position, Quaternion.identity) as GameObject;
			obj.transform.rotation = transform.rotation;
            obj.GetComponent<Rigidbody>().velocity = (cur.position - transform.position).normalized * obj.GetComponent<Bomb>().speed;
		}
			
	}

	void FixedUpdate ()
	{
		var movDelta = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical")) * speed;
		var t = this.GetComponent<Transform> ();
		transform.position = new Vector3 (transform.position.x + movDelta.x, transform.position.y, transform.position.z + movDelta.z); 
	}


}
