using UnityEngine;
using System.Collections;

public class clicmovecell : MonoBehaviour {

	public Material On;
	public Material Off;
	public dragable2[] itemsv;
	private dragable2 dragscriptv;
	public bool onoffv;
	GameObject multigov;
	multiPlayer mpv;
	
	// Use this for initialization
	void Start () {
		onoffv = false;
		multigov = GameObject.Find ("Switch player Button");
		mpv = multigov.GetComponent<multiPlayer>();
		
	}
	
	// Update is called once per frame
	void OnMouseOver () {
		
		if (Input.GetMouseButtonDown (0)) {
			
			onoffv = !onoffv;
		}
	}
	
	void Update (){
		
		itemsv = (dragable2[])FindObjectsOfType (typeof(dragable2));
		
		if (onoffv) {

			GetComponent<Renderer> ().material = On;
			
			for(int i = 0; i < itemsv.Length; i++)
			{
				if(itemsv[i].gameObject.transform.name.Contains("Cellule")){
					if (itemsv[i].gameObject.transform.name.Contains("Jaune") && mpv.onoff){
						dragscriptv = itemsv[i].GetComponent<dragable2>();
						dragscriptv.enabled = true;
					}
					if (itemsv[i].gameObject.transform.name.Contains("Violet") && !mpv.onoff){
						dragscriptv = itemsv[i].GetComponent<dragable2>();
						dragscriptv.enabled = true;
					}
				}
			}
		}
		
		itemsv = (dragable2[])FindObjectsOfType (typeof(dragable2));
		if(!onoffv){

			GetComponent<Renderer> ().material = Off;

			foreach (dragable2 go in itemsv){
				if(go.transform.name.Contains("Cellule")){
					dragscriptv = go.GetComponent<dragable2>();
					dragscriptv.enabled = false;}}
		}
	}
}