using UnityEngine;
using System.Collections;

public class loadgameselection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if lamppost in place wait few secs and load next scene
		//remember to add blackout and blackin so loading is not instant chance
		if (Input.anyKey) {
			Debug.Log("Player pressed any key, loading game selection");
			Application.LoadLevel("GameSelection");
		}
	}
}
