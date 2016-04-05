using UnityEngine;
using System.Collections;

public class destroystuff : MonoBehaviour {

	//public GameObject Vj;
	//public GameObject Vv;

	// Use this for initialization
	void OnTriggerStay (Collider other) {
		Debug.Log ("Destroyed " + other.name);
		if (other.name == "Virus Jaune")spawnvirus.Jcount = 0;
		if (other.name == "Virus Violet")spawnvirus.Vcount = 0;
		Destroy(other.gameObject);
	
	}
	
	// Update is called once per frame
	void Update () {

		}
}