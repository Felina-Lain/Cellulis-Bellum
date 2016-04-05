using UnityEngine;
using System.Collections;

public class spawnvirus : MonoBehaviour {
	
	public GameObject virusprefabJ;
	public GameObject virusprefabV;
	public float ncx;
	public float ncy;
	public float ncz;
	public bool isCreatedV = false;
	public static int Jcount;
	public static int Vcount;
	GameObject multigov;
	multiPlayer mpv;

	GameObject genvir;
	boutonvirus gvs;

	
	// Use this for initialization
	void Start () {
		multigov = GameObject.Find ("Switch player Button");
		mpv = multigov.GetComponent<multiPlayer>();
		Jcount = 0;
		Vcount = 0;

		genvir = GameObject.Find ("Generer Virus");
		gvs = genvir.GetComponent<boutonvirus>();
		
	}
	
	
	void OnMouseOver (){

		Vector3 pos = Input.mousePosition;
		pos = Camera.main.ScreenToWorldPoint (pos);			
		if (Input.GetMouseButtonDown (0)&& !isCreatedV){
			ncx = pos.x;
			ncy = pos.y;
			ncz = -5f;
			isCreatedV = true;
		}
		
		
		if (Input.GetMouseButtonUp (0) && isCreatedV && gvs.onoff) {
			if (mpv.onoff){
				GameObject newCell =(GameObject)GameObject.Instantiate(virusprefabJ);
				newCell.name = "Virus Jaune";
				newCell.tag = "Virus";
				newCell.transform.position = new Vector3 (ncx, ncy, ncz);
				Jcount = Jcount + 1;
				newCell.transform.Translate(new Vector3 (0 , 4.5f, 0));
				if (Jcount >= 2){Destroy (newCell);
					Jcount = Jcount - 1;}}
			if (!mpv.onoff){
				GameObject newCell =(GameObject)GameObject.Instantiate(virusprefabV);
				newCell.name = "Virus Violet";
				newCell.tag = "Virus";
				newCell.transform.position = new Vector3 (ncx, ncy, ncz);
				Vcount = Vcount + 1;
				newCell.transform.Translate(new Vector3 (0, 4.5f, 0));
				if (Vcount >= 2){Destroy (newCell);
					Vcount = Vcount - 1;}


}
			
		}
	}

	
}