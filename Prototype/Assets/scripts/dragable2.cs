using UnityEngine;
using System.Collections;

public class dragable2 : MonoBehaviour {
	
	Vector3 delta;
	Vector3 startPos;
	int dragState = 0;


	public void Start()
	{
		dragState = 0;
		GameObject[] gos = GameObject.FindGameObjectsWithTag("Tile");
		Lister.target = new Collider[gos.Length];
		for (int i = 0; i < gos.Length; i++) {
			Lister.target[i] = gos[i].GetComponent<Collider>();
		}

	}
	
	void Update()
	{
		// get mouse pos on this X-Y plane
		Vector3 mPos = Input.mousePosition;
		mPos.z = Camera.main.transform.InverseTransformPoint(transform.position).z;
		Vector3 mPosWorld = Camera.main.ScreenToWorldPoint(mPos);
		
		// check if we have a mouse down
		if(Input.GetMouseButtonDown(0))
		{
			// check if mouse is in bounds
			if(GetComponent<Collider>().bounds.Contains(mPosWorld))
			{
				dragState = 1;
				startPos = transform.position;
				delta = mPosWorld - transform.position;

			}
		}
		
		// drag the object if enabled
		if(dragState == 1)
		{
			// move the object with mouse
			transform.position = mPosWorld - delta;
			if(dragState == 2){
				transform.position = Vector3.MoveTowards (transform.position,startPos,1*Time.deltaTime);
				if (transform.position == startPos) dragState = 0;
			}
		}
		
		// end drag
		if(dragState == 1 && Input.GetMouseButtonUp(0))
		{	if(!isDropValid()){
				dragState = 2;
				transform.position = startPos;
			} else {
				dragState = 0;
			}
		}
}

	bool isDropValid () {
		for (int i = 0; i < Lister.target.Length; i++) {
			if(Lister.target[i].bounds.Intersects(GetComponent<Collider>().bounds))
			{
				if(Lister.highlights.Contains(Lister.target[i].gameObject))	return true;
			}
		}return false;
	}
}