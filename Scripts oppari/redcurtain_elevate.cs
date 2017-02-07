using UnityEngine;
using System.Collections;

public class redcurtain_elevate : MonoBehaviour {

	public bool isElevated;

	public float delayTime = 2;
	public Vector3 posA;
	public Vector3 posB;

	private float rate;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		ElevateCurtains();

	}

	void ElevateCurtains () {

		if (Time.timeSinceLevelLoad > delayTime) {

			transform.position = Vector3.Lerp(posA, posB, rate);
			rate += Time.deltaTime * 0.67f;



		}
		else {
			//Do Nothing///
			//

		}

		if (Time.timeSinceLevelLoad > 3) {
			//Debug.Log ("Method ElevateCurtains completed");
			isElevated = true;
		}
		else {
			isElevated = false;
		}



	}

}