using UnityEngine;
using System.Collections;

public class clictirvirus : MonoBehaviour {

	public Material On;
	public Material Off;
	public static bool shooting;
	public static bool onoffclictir;
	public GameObject prefab1;
	public float distance;
	public GameObject Vir;
	public int checkx;
	private viruslaser virlas;

	// Use this for initialization
	void Start () {
		shooting = false;
		onoffclictir = false;
		distance = 0.6f;


	}

	void Update (){

		if (multiPlayer.playerJ) {
			GameObject VirusJ = GameObject.Find("Virus Jaune");
			Vir = VirusJ;
		}
		if (!multiPlayer.playerJ) {
			GameObject VirusV = GameObject.Find("Virus Violet");
			Vir = VirusV;
		}

		if(onoffclictir){
			GetComponent<Renderer> ().material = On;
			shooting = true;
		} else {
			GetComponent<Renderer> ().material = Off;
			shooting = false;
			virlas = (viruslaser)FindObjectOfType(typeof(viruslaser));
			if(virlas != null){
					virlas.onofflaser = false;
					Destroy(virlas.gameObject);
				}
			}
		}

	
	// Update is called once per frame
	void OnMouseOver () {
		if (Vir != null) {
			Spawnaimbille();		
		
		}

	
	}


	void Spawnaimbille (){
		virustir c = Vir.GetComponent<virustir>();
		checkx = c.gix;
		if (Input.GetMouseButtonDown (0)) {
			onoffclictir = !onoffclictir;

			if (checkx%2 == 0){
				GameObject clictir4 = (GameObject)Instantiate( prefab1, Vir.transform.position + ( new Vector3(0,1,0) * distance), transform.rotation );
				clictir4.transform.parent = Vir.transform;
				clictir4.name = "aim bille 1";
				GameObject clictir5 = (GameObject)Instantiate( prefab1, Vir.transform.position + ( new Vector3(1,0,0) * distance), transform.rotation );
				clictir5.transform.parent = Vir.transform;
				clictir5.name = "aim bille 2";
				GameObject clictir6 = (GameObject)Instantiate( prefab1, Vir.transform.position + ( new Vector3(0,-1,0) * distance), transform.rotation );
				clictir6.transform.parent = Vir.transform;
				clictir6.name = "aim bille 3";
				GameObject clictir7 = (GameObject)Instantiate( prefab1, Vir.transform.position + ( new Vector3(-1,0,0) * distance), transform.rotation );
				clictir7.transform.parent = Vir.transform;
				clictir7.name = "aim bille 4";
			    GameObject clictir = (GameObject)Instantiate( prefab1, Vir.transform.position + ( new Vector3(1,1,0) * distance), transform.rotation );
			    clictir.transform.parent = Vir.transform;
				clictir.name = "aim bille 5";
			    GameObject clictir1 = (GameObject)Instantiate( prefab1, Vir.transform.position + ( new Vector3(-1,1,0) * distance), transform.rotation );
			    clictir1.transform.parent = Vir.transform;
				clictir1.name = "aim bille 6";
			    GameObject clictir2 = (GameObject)Instantiate( prefab1, Vir.transform.position + ( new Vector3(1,-1,0) * distance), transform.rotation );
			    clictir2.transform.parent = Vir.transform;
				clictir2.name = "aim bille 7";
			    GameObject clictir3 = (GameObject)Instantiate( prefab1, Vir.transform.position + ( new Vector3(-1,-1,0) * distance), transform.rotation );
			    clictir3.transform.parent = Vir.transform;
				clictir3.name = "aim bille 8";}

			if (checkx%2 == 1){
					GameObject clictir8 = (GameObject)Instantiate( prefab1, Vir.transform.position + ( new Vector3(1,1,0) * distance), transform.rotation );
					clictir8.transform.parent = Vir.transform;
					clictir8.name = "aim bille 9";
					GameObject clictir9 = (GameObject)Instantiate( prefab1, Vir.transform.position + ( new Vector3(-1,1,0) * distance), transform.rotation );
					clictir9.transform.parent = Vir.transform;
					clictir9.name = "aim bille 10";
					GameObject clictir10 = (GameObject)Instantiate( prefab1, Vir.transform.position + ( new Vector3(1,-1,0) * distance), transform.rotation );
					clictir10.transform.parent = Vir.transform;
					clictir10.name = "aim bille 11";
					GameObject clictir11 = (GameObject)Instantiate( prefab1, Vir.transform.position + ( new Vector3(-1,-1,0) * distance), transform.rotation );
					clictir11.transform.parent = Vir.transform;
					clictir11.name = "aim bille 12";
				}

			}

	}
}