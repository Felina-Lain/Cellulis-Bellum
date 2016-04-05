using UnityEngine;
using System.Collections;

public class viruslaser : MonoBehaviour {

	public bool onofflaser;
	private RaycastHit hit;
	public string billename;



	// Use this for initialization
	void Start () {
		onofflaser = false;
		billename = this.name;
			}
	
	// Update is called once per frame
	void Update (){

		if (Input.GetMouseButtonDown (0)) {

		Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
		Collider c = GetComponent<Collider>();
		RaycastHit hitInfo;
		if(!c.Raycast(r, out hitInfo, Mathf.Infinity)) return;

		onofflaser = !onofflaser;
		}

		if (onofflaser){
			if (clictirvirus.shooting) {

			switch (billename){
			
				case ("aim bille 1"):				
					lasershoot (0,1,0);
					break;

				case ("aim bille 2") :
					lasershoot (1,0,0);
					break;

				case ("aim bille 3") :
					lasershoot (0,-1,0);
					break;

				case ("aim bille 4") :
					lasershoot (-1,0,0);
					break;

				case ("aim bille 5") :
					lasershoot (1,1,0);
					break;

				case ("aim bille 6") :
					lasershoot (-1,1,0);
					break;

				case ("aim bille 7") :
					lasershoot (1,-1,0);
					break;

				case ("aim bille 8") :
					lasershoot (-1,-1,0);
					break;

				case ("aim bille 9") :
					lasershoot (1,1,0);
					break;

				case ("aim bille 10") :
					lasershoot (-1,1,0);
					break;

				case ("aim bille 11") :
					lasershoot (1,-1,0);
					break;

				case ("aim bille 12") :
					lasershoot (-1,-1,0);
					break;

				default :
					break;
	
				}
			}
	}
}

	void lasershoot(int laserx, int lasery, int laserz){

		if (Physics.Raycast (transform.position, new Vector3 (laserx, lasery, laserz), out hit)) {
				if (hit.collider.tag == "Virus" || hit.collider.tag == "cellule" || hit.collider.tag == "Noyau") {
				//Debug.DrawRay (transform.position, new Vector3 (laserx, lasery, laserz), Color.red, 50, false);
				//Debug.Log (transform.name + " hit " + hit.collider.name);
				Destroy (hit.transform.gameObject);}
				} else
					{onofflaser = !onofflaser;
						clictirvirus.onoffclictir = false;
						Debug.Log ("done shooting");
					}
	}

}