using UnityEngine;
using System.Collections;

public class formationvirus : MonoBehaviour {

	public Cell3[] cases;
	public float nbrcells;

	public int Jcount;
	public int Vcount;

	public GameObject multigov;
	public multiPlayer mpv;

	public GameObject virusprefabJ;
	public GameObject virusprefabV;


	// Use this for initialization
	void Start () {

		multigov = GameObject.Find ("Switch player Button");
		mpv = multigov.GetComponent<multiPlayer>();
		Jcount = 0;
		Vcount = 0;

		cases = (Cell3[])FindObjectsOfType (typeof(Cell3));

			
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonUp(0)){

			int NPCLayer = 0; 
			// This is used to illustrate which Layer we want to use.
			
			int NPCMask = 1 << NPCLayer; 
			// This is used to generate the Mask derived from NPC Layer.

			//Collider[] onme = Physics.OverlapSphere (this.transform.position, this.GetComponent<SphereCollider>().radius, NPCMask);
	//for (int j = 0; j < onme.Length; j++){
			//if(!onme[j].CompareTag("cellule")){

	for (int i = 0; i < cases.Length; i++) {
			if(cases[i].GetComponent<Cell3>().gridX >= 2 && cases[i].GetComponent<Cell3>().gridY >= 2 && cases[i].GetComponent<Cell3>().gridX <= 10 &&  cases[i].GetComponent<Cell3>().gridY <= 8){
					//Debug.Log (i + " X " + cases[i].GetComponent<Cell3>().gridX + " Y " + cases[i].GetComponent<Cell3>().gridY);

				Checkaround ();
				if(nbrcells > 7){
					spawnervirus ();
						}
						
					}
							
				}
			}
		}
		//}
	//}
	void Checkaround () {

		int NPCLayer = 0; 
		// This is used to illustrate which Layer we want to use.
		
		int NPCMask = 1 << NPCLayer; 
		// This is used to generate the Mask derived from NPC Layer.


		Collider[] hits = Physics.OverlapSphere (this.transform.position, 0.75f, NPCMask);

		for (int i = 0; i < hits.Length; i++) {
			//Debug.Log("Hits " + hits[i].name + i);
			if (hits[i].CompareTag("cellule")){
			nbrcells ++; 
				Debug.Log ("nbrcell " + nbrcells);
			}
			else{break;}
		
		}
	}

	void spawnervirus (){

		//Debug.Log ("spawnervirus");


		if (mpv.onoff){
			GameObject newCell =(GameObject)GameObject.Instantiate(virusprefabJ);
			newCell.name = "Virus Jaune";
			newCell.tag = "Virus";
			newCell.transform.position = new Vector3 (this.transform.position.x,this.transform.position.y, -5f);
			Jcount = Jcount + 1;
			newCell.transform.Translate(new Vector3 (0 , 4.5f, 0));
			if (Jcount >= 2){Destroy (newCell);
				Jcount = Jcount - 1;}}

		if (!mpv.onoff){
			GameObject newCell =(GameObject)GameObject.Instantiate(virusprefabV);
			newCell.name = "Virus Violet";
			newCell.tag = "Virus";
			newCell.transform.position = new Vector3 (this.transform.position.x,this.transform.position.y, -5f);
			Vcount = Vcount + 1;
			newCell.transform.Translate(new Vector3 (0, 4.5f, 0));
			if (Vcount >= 2){Destroy (newCell);
				Vcount = Vcount - 1;}
			}
	}
}