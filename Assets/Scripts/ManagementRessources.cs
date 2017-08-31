using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagementRessources : MonoBehaviour {
	// Basic income of resources, hardcoded for now..
	public int water = 1000;
	public int food = 1000;
	//public int fuel = 200;
	public int rawMaterial = 50;
	public int comburant = 0;
	public int energy = 200;

	public int maxWater = 2000;
	public int maxFood = 1500;
	//public int maxFuel = 400;
	public int maxRawMaterial = 100;
	public int maxComburant = 100;
	public int maxEnergy = 200;

	// Quantity lost every X minutes
	public int quantityLost = 1;

	public Text waterResourcesText;
	public Text foodResourcesText;

	// Delay before executing the lose of resources
	private float delayStart = 1.0f;
	// Resources will be lost every 5 seconds
	private float timeBeforeExecute = 5.0f;

	void Start () {
		DisplayResources ();
		// Every X seconds we execute the losing resources method
		InvokeRepeating("LoseResourcesBasic", delayStart, timeBeforeExecute);
	}

	void LoseResourcesBasic() {
		if (water > 0) {
			water -= quantityLost;
		}

		if (water <= 0) {
			Debug.Log ("Your water is running low!");
		}

		if (food > 0) {
			food -= quantityLost;
		}

		if (food <= 0) {
			Debug.Log ("Your food is running low!");
		}

		DisplayResources ();
	}

	public void DisplayResources () {
		waterResourcesText.text = "Water : " + water + " / " + maxWater;
		foodResourcesText.text = "Food : " + food + " / " + maxFood;
	}
}
