using UnityEngine;
using System.Collections;

public class titleButtonPlay : MonoBehaviour {

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
		Application.LoadLevel("scene");
	}

}
