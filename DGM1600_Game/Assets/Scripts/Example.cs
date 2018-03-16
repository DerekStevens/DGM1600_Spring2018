using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour {
	//Scripts should be considered Behaviour components in Unity

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R)){
			//Drill down to the value you want gameObeject(object the script is attached to).renderer(A component attached to the gameObject called Mesh Renderer).material(material attached to that renderer).color
			//This is all set to a shortcut called red that is part of the "Color" class.
			gameObject.GetComponent<Renderer>().material.color = Color.red;
		}
		if(Input.GetKeyDown(KeyCode.G)){
			gameObject.GetComponent<Renderer>().material.color = Color.green;
		}
		if(Input.GetKeyDown(KeyCode.B)){
			gameObject.GetComponent<Renderer>().material.color = Color.blue;
		}
	}
}
