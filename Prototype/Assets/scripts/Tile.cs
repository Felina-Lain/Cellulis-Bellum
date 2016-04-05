/*using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	public Cell3 cell3script;

	void Start (){
		cell3script = GetComponent<Cell3>();
		OnTriggerEnter ();
		}
	// Use this for initialization
	void OnTriggerEnter () {

		cell3script.occuped = true;
	
	}
	
	// Update is called once per frame
	void OnTriggerExit () {

		cell3script.occuped = false;
	}
}
*/