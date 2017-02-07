using UnityEngine;
using System.Collections;

public class FadeBackground : MonoBehaviour {
	public float alphavalue;
	public float fadingtime;

	move_furniture movefurnitureScript;

	// Use this for initialization
	void Start () {
		movefurnitureScript = GameObject.Find("Furniture").GetComponent<move_furniture>();
		StartCoroutine(FadeTo(0f, 1f));
	}
	
	// Update is called once per frame
	void Update () {

		if (movefurnitureScript.isLampInDestination == true) {
			StartCoroutine(FadeTo(alphavalue, fadingtime));
		}
	}

	IEnumerator FadeTo(float aValue, float aTime)
	{
		float alpha = transform.GetComponent<Renderer>().material.color.a;
		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
		{
			Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha,aValue,t));
			transform.GetComponent<Renderer>().material.color = newColor;
			yield return null;
		}
	}
}
