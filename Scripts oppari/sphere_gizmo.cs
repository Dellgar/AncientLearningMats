using UnityEngine;
using System.Collections;

public class sphere_gizmo : MonoBehaviour {
	public float size;

	void OnDrawGizmos() {
		Gizmos.color = Color.yellow;
		Gizmos.DrawSphere(transform.position, size);
	}
}
