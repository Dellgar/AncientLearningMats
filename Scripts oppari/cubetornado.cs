using UnityEngine;
using System.Collections;

public class cubetornado : MonoBehaviour {

	public Transform[] waypointsArray;
	public int currentWaypoint;
	public float speed = 5;

	private int helper;

	private Vector3 targetPoint;
	private Vector3 moveDirection;

	// Use this for initialization
	void Start () {
		targetPoint = waypointsArray[currentWaypoint].position;
		moveDirection = targetPoint - transform.position;
	}
	
	// Update is called once per in frame
	void Update () {

		BuildingTornado();

	}

	void BuildingTornado() {

		helper = currentWaypoint;
		
		targetPoint = waypointsArray[currentWaypoint].position;
		moveDirection = targetPoint - transform.position;
		
		transform.LookAt(waypointsArray[currentWaypoint]);
		
		GetComponent<Rigidbody>().velocity = moveDirection.normalized * speed;
		
		if(moveDirection.magnitude < 1){
			
			currentWaypoint++;
			if (helper > 0) {
				//Debug.Log("waypoint is now anything else than 0");
				GetComponent<Renderer>().enabled = true;
			}
			if(currentWaypoint == waypointsArray.Length){
				GetComponent<Renderer>().enabled = false;
				currentWaypoint = 0;
				
				
			}
		}

	}
}
