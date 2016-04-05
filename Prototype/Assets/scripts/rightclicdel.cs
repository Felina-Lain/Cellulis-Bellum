using UnityEngine;
using System.Collections;

public class rightclicdel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnMouseOver () {
	
		Vector3 pos = Input.mousePosition;
		pos = Camera.main.ScreenToWorldPoint (pos);			
		if (Input.GetMouseButtonDown (1)) {
			if (this.name.Contains("Virus Jaune"));{
				spawnvirus.Jcount = 0;
			}
			if (this.name.Contains("Virus Violet"));{
				spawnvirus.Vcount = 0;
			}
			Destroy(this.gameObject);	}

	}
}
