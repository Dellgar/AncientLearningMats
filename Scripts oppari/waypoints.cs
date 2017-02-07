using UnityEngine;
using System.Collections;

public class waypoints : MonoBehaviour {
	
	public Transform[] waypointsArray;
	public int currentWaypoint;
	public float speed = 5;
	
	private Vector3 targetPoint;
	private Vector3 moveDirection;
	
	// Use this for initialization
	void Start () {
		targetPoint = waypointsArray[currentWaypoint].position;
		moveDirection = targetPoint - transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		
		targetPoint = waypointsArray[currentWaypoint].position;
		moveDirection = targetPoint - transform.position;
		
		transform.LookAt(waypointsArray[currentWaypoint]);
		
		GetComponent<Rigidbody>().velocity = moveDirection.normalized * speed;
		
		if(moveDirection.magnitude < 1){
			
			currentWaypoint++;
		
			if(currentWaypoint == waypointsArray.Length){
				currentWaypoint = 0;
				
			}
		}
		
	}
}
