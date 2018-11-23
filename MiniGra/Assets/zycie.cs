using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zycie : MonoBehaviour {

	public GameObject Gracz;
	GameObject platforma; 

	// Use this for initialization
	void Start () {

		platforma = GetComponent<GameObject> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Gracz.transform.position.x > platforma.transform.position.x) {
			Destroy (GetComponent<GameObject>());
		}
	}
}
