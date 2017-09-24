using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionIndicator : MonoBehaviour {
	MouseManager mm;

	// Use this for initialization
	void Start () {
		mm = GameObject.FindObjectOfType<MouseManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (mm.selectedObject != null) {
			Bounds bigBounds = mm.selectedObject.GetComponentInChildren<Renderer> ().bounds;

			float margin = 2f;

			this.transform.position = new Vector3(bigBounds.center.x, 0, bigBounds.center.z);
			this.transform.localScale = new Vector3 (bigBounds.size.x * margin, bigBounds.size.y, bigBounds.size.z * margin);
		}
	}
}
