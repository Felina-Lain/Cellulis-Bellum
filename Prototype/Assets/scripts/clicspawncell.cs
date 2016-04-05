using UnityEngine;
using System.Collections;

public class clicspawncell : MonoBehaviour {
	
	public Material On;
	public Material Off;
	public spawncell[] itemsv;
	private spawncell spawnscript;
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
		
		itemsv = (spawncell[])FindObjectsOfType (typeof(spawncell));
		
		if (onoffv) {
			
			GetComponent<Renderer> ().material = On;
			
			for(int i = 0; i < itemsv.Length; i++)
			{
					if(mpv.onoff){
						spawnscript = itemsv[i].GetComponent<spawncell>();
						spawnscript.enabled = true;
					}
					if (!mpv.onoff){
						spawnscript = itemsv[i].GetComponent<spawncell>();
						spawnscript.enabled = true;
					}
				}
			}
		
		itemsv = (spawncell[])FindObjectsOfType (typeof(spawncell));
		if(!onoffv){
			
			GetComponent<Renderer> ().material = Off;
			
			foreach (spawncell go in itemsv){
					spawnscript = go.GetComponent<spawncell>();
					spawnscript.enabled = false;}}
	}
}