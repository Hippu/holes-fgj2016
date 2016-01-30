using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public string nextLevel;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Player") {
			UnityEngine.SceneManagement.SceneManager.LoadScene (nextLevel);
		}
	}
}
