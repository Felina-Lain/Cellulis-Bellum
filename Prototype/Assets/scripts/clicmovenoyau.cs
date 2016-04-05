using UnityEngine;
using System.Collections;

public class clicmovenoyau : MonoBehaviour {

	public Material On;
	public Material Off;
	public GameObject noyJ;
	public GameObject noyV;
	public dragable2 dragscriptJ;
	public dragable2 dragscriptV;
	public bool onoff;
	GameObject multigo;
	multiPlayer mp;
	
	// Use this for initialization
	void Start () {
		onoff = false;
		noyV = GameObject.Find ("Noyau Violet");
		noyJ = GameObject.Find ("Noyau Jaune");
		multigo = GameObject.Find ("Switch player Button");
		mp = multigo.GetComponent<multiPlayer>();
		dragscriptJ = noyJ.GetComponent<dragable2>();
		dragscriptV = noyV.GetComponent<dragable2>();

		
	}
	
	// Update is called once per frame
	void OnMouseOver () {
		
			if (Input.GetMouseButtonDown (0)) {

						onoff = !onoff;
				}
		}

	void Update (){

		if (onoff) {

			GetComponent<Renderer> ().material = On;
			
				if (mp.onoff){
					
					dragscriptJ.enabled = true;}

				if (!mp.onoff){
					
					dragscriptV.enabled = true;}

			
		}
		if(!onoff){

			GetComponent<Renderer> ().material = Off;

			dragscriptV.enabled = false;
			dragscriptJ.enabled = false;
					}
	}
}