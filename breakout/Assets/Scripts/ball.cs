using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	Rigidbody2D rig2d;

	// Use this for initialization
	void Start () {
		rig2d = this.gameObject.GetComponent<Rigidbody2D> ();
		rig2d.AddForce (new Vector2 (50f, 500f));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col) {
		//Debug.Log ("collll BRICK");
		//Destroy(gameObject);
	}
}
