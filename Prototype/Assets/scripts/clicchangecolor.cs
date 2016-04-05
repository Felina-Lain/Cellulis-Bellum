using UnityEngine;
using System.Collections;

public class clicchangecolor : MonoBehaviour {

	public GameObject celljprefab;
	public GameObject cellvprefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnMouseOver () {
		
		Vector3 pos = Input.mousePosition;
		pos = Camera.main.ScreenToWorldPoint (pos);			
		if (Input.GetMouseButtonDown (2)) {

			if (this.name.Contains("Cellule Jaune")){
				GameObject newCell =(GameObject)GameObject.Instantiate(cellvprefab);
				newCell.name = "Cellule Violette";
				newCell.tag = "cellule";
				newCell.transform.position = this.transform.position;
			}
			if (this.name.Contains("Cellule Violette")){
				GameObject newCell =(GameObject)GameObject.Instantiate(celljprefab);
				newCell.name = "Cellule Jaune";
				newCell.tag = "cellule";
				newCell.transform.position = this.transform.position;
			}

			Destroy(this.gameObject);}
		
	}
}
