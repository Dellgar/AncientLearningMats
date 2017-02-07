using UnityEngine;
using System.Collections;

public class accelerometerInput : MonoBehaviour {

	public float speed = 0.33f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Input.acceleration.x * speed, 0, 0);//-Input.acceleration.z);
	}
}
