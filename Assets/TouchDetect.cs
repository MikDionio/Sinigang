using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDetect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.touchCount == 1)
		{
			Vector3 wp = Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position);//convert touch coordinates to world coordinates
			Vector2 touchPos = new Vector2 (wp.x, wp.y);
			if (GetComponent<Collider2D> () == Physics2D.OverlapPoint (touchPos) && Input.GetTouch (0).phase == TouchPhase.Began) {
				if (this.gameObject.CompareTag ("Sinigang")) {
					Debug.Log ("Filipino");
				} else {
					Debug.Log ("NOt a Filipino!");
				}
			}
		}
	}
}
