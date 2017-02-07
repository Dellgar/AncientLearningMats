using UnityEngine;
using System.Collections;

public class bricks : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 
	}

	void OnCollisionEnter (Collision col) {
		Debug.Log ("collll BRICK");
		Destroy (gameObject);
	}
}
