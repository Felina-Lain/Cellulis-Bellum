using UnityEngine;
using System.Collections;

public class boutonvirus : MonoBehaviour {

	public bool onoff;
	public Material On;
	public Material Off;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (onoff) GetComponent<Renderer> ().material = On;
		if(!onoff) GetComponent<Renderer> ().material = Off;
	
	}

	void OnMouseOver () {
		
		if (Input.GetMouseButtonDown (0)) {
			
			onoff = !onoff;
		}

	}

}
