using UnityEngine;
using System.Collections;

public class buttonreturnmenu : MonoBehaviour {


	void OnMouseUp(){
		Debug.Log("Click");
		Application.LoadLevel("Title");
	}

}
