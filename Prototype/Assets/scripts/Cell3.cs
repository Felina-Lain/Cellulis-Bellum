using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cell3 : MonoBehaviour {
	
	public int gridX ;
	public int gridY ;
	public GridGen2 grid;
	public Vector3 coltar;
	public Color jelly;
	public clicmovevirus cmv1;
	public clicmovenoyau cmv2;
	public clicmovecell cmv3;

	//public bool occuped = false;
	void Start (){

		GameObject bouton1 = GameObject.Find("Deplacer Virus");
		cmv1 = bouton1.GetComponent<clicmovevirus>();
				
		GameObject bouton2 = GameObject.Find("Deplacer Noyau");
		cmv2 = bouton2.GetComponent<clicmovenoyau>();

		GameObject bouton3 = GameObject.Find("Eclatement");
		cmv3 = bouton3.GetComponent<clicmovecell>();

		}


	//void OnTriggerStay (Collider col){
	void Update (){
		if(cmv1.onoffv || cmv2.onoff || cmv3.onoffv){
		Collider[] colliding = Physics.OverlapSphere(transform.position, this.GetComponent<SphereCollider>().radius);
		for (int i = 0; i < colliding.Length; i++) {

			if (Input.GetMouseButton(0) && Lister.highlights.Count == 0){
				//check si souris dessus, car verif par priorité de case fait bugger
				Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
				Collider c = GetComponent<Collider>();
				RaycastHit hitInfo;
				if(!c.Raycast(r, out hitInfo, Mathf.Infinity)) return; // teste uniquement la collision avec CE collider
				
				if (colliding[i].tag == "cellule") {
					//Diagonals();
					direction(1, 1, 13);
					direction(-1, -1, 13);
					direction(-1, 1, 13);
					direction(1, -1, 13);
					if(gridX%2 == 0)
					{
						direction(0, 2, 13);
						direction(-2, 0, 13);
						direction(0, -2, 13);
						direction(2, 0, 13);
					}
					
					//GetComponent<Renderer>().material.color = Color.green;
				}
				if (colliding[i].tag == "Noyau" || colliding[i].tag == "Virus") {
					//Diagonals();
					direction(1, 1, 1);
					direction(-1, -1, 1);
					direction(-1, 1, 1);
					direction(1, -1, 1);
					if(gridX%2 == 0)
					{
						direction(0, 2, 1);
						direction(-2, 0, 1);
						direction(0, -2, 1);
						direction(2, 0, 1);
					}
					
					//GetComponent<Renderer>().material.color = Color.green;
				}
				else {
					GetComponent<Renderer> ().material.color = jelly;
				}	
				
			}
			//}
			
			
			//void Update (){
			if (Input.GetMouseButtonUp (0) || Input.GetMouseButtonUp(1)) {
				for (int j = 0; j < Lister.highlights.Count; j++) {
					GameObject o = Lister.highlights [j];
					o.GetComponent<Renderer> ().material.color = jelly;
				}
				Lister.highlights.Clear ();

				}
			}
		}
	}
		
		
	void direction(int dirx, int diry, int distance)
	{
		int x = gridX;
		int y = gridY;

		for(int nbMove = 0; nbMove < distance; nbMove++)
		{
			x += dirx;
			y += diry;
			//Debug.Log(x+","+y);
			if (x < 0 || x >=grid.nbCellW || y < 0 || y >=grid.nbCellH){
				//Debug.Log ("SKIP");
				continue;
			}
			GameObject c = grid.grid[x + y * grid.nbCellW];
			c.GetComponent<Renderer>().material.color = Color.red;
			Lister.highlights.Add(c);
		}
	}
}