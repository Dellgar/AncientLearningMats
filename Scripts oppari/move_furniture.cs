using UnityEngine;
using System.Collections;

public class move_furniture : MonoBehaviour {
	private GameObject smalltree;
	private GameObject bigtree;
	private GameObject lamp;
	private GameObject dancingman;

	private float rate1;
	private float rate2;
	private float rate3;
	private float rate4;


	public Vector3 smalltreeposA;
	public Vector3 smalltreeposB;
	public Vector3 bigtreeposA;
	public Vector3 bigtreeposB;
	public Vector3 lampposA;
	public Vector3 lampposB;
	public Vector3 dancingmanposA;
	public Vector3 dancingmanposB;

	public bool isLampInDestination = false;


	move_cubetornado cubetornadoScript;			// Reference to script called "move_tornado", reference is assigned to variable cubetornadoScript
	
	void Start () {
		// move_cubetornado script is in another object so we need to find it
		cubetornadoScript = GameObject.Find("Tornado_beefy").GetComponent<move_cubetornado>();
	
		smalltree = GameObject.Find("toon-pine-tree_small");
		bigtree = GameObject.Find("toon-pine-tree_big");
		lamp = GameObject.Find("LampPost");
		dancingman = GameObject.Find("DancingCubeman");
	}
	
	// Update is called once per frame
	void Update () {

		MoveTrees();

		if (lamp.transform.position == lampposB) {
			isLampInDestination = true;

			dancingman.transform.position = Vector3.Lerp(dancingmanposA, dancingmanposB, rate4);
			rate4 += Time.deltaTime * 0.7f;

		}

	}

	void MoveTrees () {

		if(cubetornadoScript.isFadingBG == true) {
			smalltree.transform.position = Vector3.Lerp(smalltreeposA, smalltreeposB, rate1);
			bigtree.transform.position = Vector3.Lerp(bigtreeposA, bigtreeposB, rate2);

			rate1 += Time.deltaTime * 1.1f;
			rate2 += Time.deltaTime * 0.8f;
		}

		if (cubetornadoScript.isDestroyed == true) {
		
			lamp.transform.position = Vector3.Lerp(lampposA, lampposB, rate3);
		
			rate3 += Time.deltaTime * 1.3f;
		}

	}
}
