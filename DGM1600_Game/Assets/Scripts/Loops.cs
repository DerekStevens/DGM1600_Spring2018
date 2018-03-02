using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

	public int beer = 99;

	public int bacon = 9;


	// Use this for initialization
	void Start () {

		for(int i = 99; i> beer; i--){
			print(i + "bottles of beer on the wall");
		}

		while(bacon >= 0){
			print("Mmmmmm bacon!!! "+ bacon);

			bacon --;
		}

		if(bacon <= 0){
			print("Ohhhh out of BACON!!!");
		}

		bool isFired = false;

		do{
			print("You're FIRED!!! - Donald Trump");
		}

	while(isFired == true);

	string[] churro = new string[3];

	churro[0] = "First Churro, Yum!";
	churro[1] = "Second Churro, Yummy!";
	churro[3] = "Third Churro, Yummers!";

	foreach(string item in churro){
		print(item); 
	}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
