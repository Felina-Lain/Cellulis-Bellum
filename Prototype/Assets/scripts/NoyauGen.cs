using UnityEngine;
using System.Collections;

public class NoyauGen : MonoBehaviour {

	public GameObject noyauprefab;
	public float ncxV;
	public float ncxJ;
	public float ncy;
	public float ncz;

	void Awake()
	{

	}
	// Use this for initialization
	void Start () {
			ncxJ = 3.75f;
			ncy = 6.25f;
			ncz = -0.5f;
			ncxV = 11.25f;;

		if (noyauprefab.name == "Noyau 1"){
		GameObject NoyauViolet =
			(GameObject)GameObject.Instantiate(noyauprefab);
			NoyauViolet.name = "Noyau Violet";
			NoyauViolet.transform.position = new Vector3 (ncxV, ncy, ncz);
		}
		if (noyauprefab.name == "Noyau"){
			GameObject NoyauJaune =
				(GameObject)GameObject.Instantiate(noyauprefab);
			NoyauJaune.name = "Noyau Jaune";
			NoyauJaune.transform.position = new Vector3 (ncxJ, ncy, ncz);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
