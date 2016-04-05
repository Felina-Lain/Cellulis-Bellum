using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Lister : MonoBehaviour {

	public static bool isCreated = false;
	public static List<GameObject> highlights = new List<GameObject>();//stock des cases accessibles pour Cell3
	public static Collider[] target;//stock des case pour draggable2
	public static dragable2[] pions;

	public static List< List<Cell3> > chaines = new List<List<Cell3>>();


	public static void checkConnection(Cell3 newCell, Cell3 other)
	{
		bool inserted = false;
		for (int i = 0; i < chaines.Count; i++) 
		{
			if(chaines[i].Contains(other))
			{
				if(chaines[i].Contains(newCell) == false)
				{
					chaines[i].Add(newCell);
					inserted = true;
				}
			}
		}

		if(inserted == false)
		{
			List<Cell3> newList = new List<Cell3>();
			newList.Add(newCell);
			newList.Add(other);
			chaines.Add(newList);
		}
	}


	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.P)){

			Debug.Log ("Chaines " + chaines);
			for (int i = 0; i < chaines.Count; i++) {
				Debug.Log (chaines[i]);
				for (int j = 0; j < chaines[i].Count; j++) {
					Debug.Log(chaines[i][j].name);
				}
			}
		}

		}
	}