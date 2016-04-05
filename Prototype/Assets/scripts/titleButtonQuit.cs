using UnityEngine;
using System.Collections;

public class titleButtonQuit : MonoBehaviour {

	public Material couleurDepart;
	public Material couleurFin;

	void OnMouseEnter(){
		GetComponent<Renderer>().material = couleurFin;
	
	}
	
	void OnMouseDown(){
		GetComponent<Renderer>().material = couleurDepart;

	}
	
	void OnMouseUp(){
		Debug.Log("Click");
		Application.Quit();
	}

	void Update () {
		if (Input.GetKey ("escape")) {
			Debug.Log ("quitting");
			Application.LoadLevel ("Title");
				}
	}

}
