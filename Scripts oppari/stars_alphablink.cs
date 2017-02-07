using UnityEngine;
using System.Collections;

public class stars_alphablink : MonoBehaviour {

	public float alphavalue;
	public float fadingtime;
	public float countdown;

	private bool isAbleToCount;

	move_cubetornado cubetornadoScript;			// Reference to script called "move_tornado", reference is assigned to variable cubetornadoScript

	void Start () {
		// move_cubetornado script is in another object so we need to find it
		cubetornadoScript = GameObject.Find("Tornado_beefy").GetComponent<move_cubetornado>();

		// Fade object (stars) to invisible, so they can slowly appear when needed
		StartCoroutine(FadeTo(0.0f, 0.5f));
	}

	void Update ()
	{

		FadingStars();
	}

	void FadingStars () {

		// When tornado collides with trigger isFadingBG is set to true
		// Sets isAbleToCount to true
		if ( cubetornadoScript.isFadingBG == true ) {
			
			isAbleToCount = true;
		}

		// Both of the booleans is needed to start countdown 
		// If isAbleToCount goes false we cannot perform countdown
		if ( cubetornadoScript.isFadingBG == true && isAbleToCount == true ) {
			
			countdown -= Time.deltaTime;
		}

		// When countdown reaches zero, it stays in that value (no negative value).
		// Also, when countdown reaches zero value, the countdown has been performed so isAbleToCount is set to false;
		// Now that countdown is done, its time to start coroutine (affects to fading)
		if (countdown <= 0) {
			countdown = 0;
			isAbleToCount = false;
			StartCoroutine(FadeTo(alphavalue, fadingtime));
		}
	}

	//Affects to alpha value like desired in desired time
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
