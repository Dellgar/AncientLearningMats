using UnityEngine;
using System.Collections;

public class paddle : MonoBehaviour {
	//public float speed = 10.0f;
	private float borderline = 8.15f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//PC CONTROLLER
		if (Input.GetAxis ("Horizontal") < 0) {
			Debug.Log ("Left");
			transform.Translate (-0.1f, 0, 0);
		}
		if (Input.GetAxis ("Horizontal") > 0) {
			Debug.Log ("Right");	
			transform.Translate (0.1f, 0, 0);
		}

		if (transform.position.x <= -borderline) {
			//transform.position = Vector3(-borderline, 0, 0);
			Debug.Log ("left border");
			transform.position = new Vector3 (-borderline, -4f, 0);
		}
		if (transform.position.x >= borderline) {
			Debug.Log ("right border");
			transform.position = new Vector3 (borderline, -4f, 0);
		}
	}


}
