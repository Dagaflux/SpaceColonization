using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour {

	public GameObject selectedObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit hitInfo;

		if (Physics.Raycast (ray, out hitInfo)) {
			// We find the parent's parent, it's the one defining our object
			// Ex: Mouse hover capsule collider -> Find the "Complex Collider" gameobject
			// And then find the GameObject container's name, might be Unit
			GameObject hitObject = hitInfo.transform.parent.parent.gameObject;

			SelectObject (hitObject);

		} else {
			ClearSelection ();
		}
	}

	void SelectObject (GameObject obj) 
	{
		if (selectedObject != null) {
			if (obj == selectedObject) {
				return;

				ClearSelection ();
			}
		}

		selectedObject = obj;
	}

	void ClearSelection () 
	{
		selectedObject = null;
	}
}
