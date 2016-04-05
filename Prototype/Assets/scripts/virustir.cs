using UnityEngine;
using System.Collections;

public class virustir : MonoBehaviour {

	public Cell3 gridX;
	public int gix;
	public Collider[] colliding;

		// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log ("Virus tir " + clictirvirus.shooting);

	
		colliding = Physics.OverlapSphere(transform.position, 0.5f);
		if(colliding != null && colliding.Length > 0){
			for (int i = 0; i < colliding.Length; i++) {
				if(colliding[i].GetComponent<Cell3> () != null){
						Cell3 c = colliding[i].GetComponent<Cell3> ();						
						gix = c.gridX;
					Debug.Log ("grix " + gix );}
				}
		}
	}
}