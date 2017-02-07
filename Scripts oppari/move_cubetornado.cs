using UnityEngine;
using System.Collections;

public class move_cubetornado : MonoBehaviour {

	public Vector3 posA;
	public Vector3 posB;

	public bool isFadingBG = false;
	public bool isDestroyed = false;

	private float rate;
	private GameObject TornadoFinish;
	private GameObject TornadoHalfway;
	private GameObject Tornado_container;

	redcurtain_elevate curtainScript;

	// Use this for initialization
	void Start () {
		curtainScript = GameObject.Find("Curtains").GetComponent<redcurtain_elevate>();
		TornadoFinish = GameObject.Find("TornadoFinish");
		TornadoHalfway = GameObject.Find("TornadoHalfway");
		Tornado_container = GameObject.Find("Tornado_container");
	}
	
	// Update is called once per frame
	void Update () {
		if(curtainScript.isElevated == true) {
			transform.position = Vector3.Lerp(posA, posB, rate);
			rate += Time.deltaTime * 0.21f;
		}

	}

	void OnTriggerEnter(Collider other) {

		if(other.name == "TornadoHalfway") {
			Debug.Log("Tornado collided with TornadoHalfway");
			isFadingBG = true;
			Destroy(TornadoHalfway);

		}

		if(other.name == "TornadoFinish") {
			Debug.Log("Tornado collided with TornadoFinish");
			isDestroyed = true;
			Destroy(Tornado_container);								//Destroy the Tornados inner contain, so the isFading bool is still usable
			Destroy(TornadoFinish);


		}
	}
}
