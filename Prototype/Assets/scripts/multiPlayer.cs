using UnityEngine;
using System.Collections;

public class multiPlayer : MonoBehaviour {
	
	public Material Jaune;
	public Material Violet;
	public bool onoff;
	public static bool playerJ;
	private viruslaser[] virlas;
	private dragable2 dragscript;


	void Start(){
		onoff = true;
		playerJ = true;
			
	}
	
	void OnMouseOver(){


		if(Input.GetMouseButtonDown(0)){
			onoff = !onoff; // toggles onoff at each click
			clictirvirus.onoffclictir = false;

			GameObject bouton1 = GameObject.Find("Deplacer Virus");
			clicmovevirus cmv1 = bouton1.GetComponent<clicmovevirus>();
			cmv1.onoffv = false;

			GameObject bouton2 = GameObject.Find("Deplacer Noyau");
			clicmovenoyau cmv2 = bouton2.GetComponent<clicmovenoyau>();
			cmv2.onoff = false;

			GameObject bouton3 = GameObject.Find("Eclatement");
			clicmovecell cmv3 = bouton3.GetComponent<clicmovecell>();
			cmv3.onoffv = false;

			GameObject bouton4 = GameObject.Find("Multiplication");
			clicspawncell cmv4 = bouton4.GetComponent<clicspawncell>();
			cmv4.onoffv = false;

			GameObject bouton5 = GameObject.Find("Generer Virus");
			boutonvirus cmv5 = bouton5.GetComponent<boutonvirus>();
			cmv5.onoff = false;

				virlas = (viruslaser[])FindObjectsOfType(typeof(viruslaser));
				for(int i = 0; i < virlas.Length; i++)
				{
					Destroy(virlas[i].gameObject);
				}

			if (onoff){
				playerJ = true;
				GetComponent<Renderer> ().material = Jaune;

			} 


			else {
				playerJ = false;
				GetComponent<Renderer> ().material = Violet;
			}
		}

	}
}
