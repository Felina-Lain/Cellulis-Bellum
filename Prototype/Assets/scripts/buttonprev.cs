using UnityEngine;
using System.Collections;

public class buttonprev : MonoBehaviour {

	public Camera cam1;
	public Camera cam2;


	void OnMouseUp(){
		Debug.Log("Click");
		cam1.enabled = true;
		cam2.enabled = false;
	}
}
