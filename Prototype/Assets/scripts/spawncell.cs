using UnityEngine;
using System.Collections;

public class spawncell : MonoBehaviour {

	public GameObject cellprefabJ;
	public GameObject cellprefabV;
	public float ncx;
	public float ncy;
	public float ncz;
	GameObject multigov;
	multiPlayer mpv;
	GameObject clicker;
	clicspawncell csc;

	// Use this for initialization
	void Start () {
		multigov = GameObject.Find ("Switch player Button");
		mpv = multigov.GetComponent<multiPlayer>();
		clicker = GameObject.Find ("Multiplication");
		csc = clicker.GetComponent<clicspawncell>();
	}


	void OnMouseOver (){

		Vector3 pos = Input.mousePosition;
		pos = Camera.main.ScreenToWorldPoint (pos);			
		if (Input.GetMouseButtonDown (0)&& !Lister.isCreated){
			ncx = pos.x;
			ncy = pos.y;
			ncz = -0.5f;
			Lister.isCreated = true;

		}

		if (Input.GetMouseButtonUp (0) && !csc.onoffv)return;

		if (Input.GetMouseButtonUp (0) && Lister.isCreated && csc.onoffv) {

			if (mpv.onoff){
				GameObject newCell =(GameObject)GameObject.Instantiate(cellprefabJ);
				newCell.name = "Cellule Jaune";
				newCell.tag = "cellule";
				newCell.transform.position = new Vector3 (ncx, ncy, ncz);}
			if (!mpv.onoff){
				GameObject newCell =(GameObject)GameObject.Instantiate(cellprefabV);
				newCell.name = "Cellule Violette";
				newCell.tag = "cellule";
				newCell.transform.position = new Vector3 (ncx, ncy, ncz);}

			Lister.isCreated = false;

				}

		}
	
}