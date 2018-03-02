using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour {
	public float moveSpeed;
	public Transform target;

	// public int damage;

	// public GameObject pcHealth;

void Wandering(){
		print("Chicken is Wandering!");

	// makes the animal wander
	transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
	int randomNum = Random.Range(0,360);
	//Projects Raycast always forward
	Vector3 fwd = transform.TransformDirection(-Vector3.forward);
	RaycastHit hit;

	// Draws the physical ray
	Debug.DrawRay(transform.position,fwd*3,Color.red);
	// Detects collision using raycast
	if(Physics.Raycast(transform.position,fwd,out hit,3)){

		if(hit.collider.tag == "Wall"){
			transform.Rotate(0,randomNum,0);
		}
	}
}

// void Follow(){
// 		print("wolf is following!");
// 		transform.LookAt(target);
// 		transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
// }

void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "Player"){
			print("Player Stinks!");
			//follow();
		}else{
			Wandering();
		}
	}
	}