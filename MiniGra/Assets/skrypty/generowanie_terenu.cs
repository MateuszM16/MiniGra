﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class generowanie_terenu : MonoBehaviour {


	public GameObject Platforma_1;
	public GameObject Gracz;

	int x=0;
	int y=0;

	int a=8;
	int b = 11;
	int c=-3;
	int d = 3;
	float xx=0;

	public Text odleglosc;

	int odlegloscint;


	// Use this for initialization
	void Start () {


	
	}
		


	// Update is called once per frame
	void Update () {

		odlegloscint = Mathf.RoundToInt (Gracz.transform.position.x);
		odleglosc.text = "Distance: " + odlegloscint;

		//punkty.transform.position.z = odlegloscint;

		if (Gracz.transform.position.x+30 > x) {


			x += Random.Range (a, b);
			y += Random.Range (c, d);


			xx=(x+Gracz.transform.position.x / 20);
		
	
		
			Instantiate (Platforma_1, new Vector2 (xx, y), Quaternion.identity);
		}



	}
}
