using UnityEngine;
using System.Collections;

public class GridGen2 : MonoBehaviour {

	public static GridGen2 instance = null;
	
	public int nbCellH = 4;
	public int nbCellW = 4;
	public float cellW = 1;
	public float spacing = 0.5f;
	public GameObject tile;
	public Cell3 gridX;
	public Cell3 gridY;
	//public GameObject prefabpion;
	[HideInInspector]public GameObject[] grid; //stock des cases
	
	GameObject root;

	void Awake()
	{
		instance = this;
	}
	
	// Use this for initialization
	void Start () {
		grid = new GameObject[nbCellH * nbCellW];
		root = new GameObject("GRID-ROOT");
		Vector3 pos = new Vector3();
		
		for(int y=0; y <nbCellH; y++) {
			
			pos.y = y* (cellW + spacing);
			
			for(int x=0; x <nbCellW; x++){
				if(x % 2 != y % 2) continue;
				
				pos.x = x*(cellW + spacing);
				
				GameObject cell =
					(GameObject)GameObject.Instantiate(tile);
				cell.name = "Cell-" + x + "-" + y;					
				Cell3 c = cell.GetComponent<Cell3>();
				c.gridX = x;
				c.gridY = y;
				c.grid = this;
				//c.prefabpion = prefabpion;
				cell.transform.position = pos;
				cell.transform.localScale = new Vector3(cellW, cellW, 1);
				cell.transform.parent = root.transform;
				grid[y*nbCellW +x] = cell;
			}
		}
		
	}

	public Cell3 getCellAt(int x, int y)
	{
		if(x < 0 || x >= nbCellW || y < 0 || y >= nbCellH) return null;
		GameObject o = grid[y*nbCellW +x];
		if(o != null) return o.GetComponent<Cell3>();
		else return null;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}