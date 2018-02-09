using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : MonoBehaviour {

	// Public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;
	public Transform chickenPen;
	public int points = 10;
	void Start () {
		// chickenPen = GameObject.Find("Chicken")
	}
	
	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "Player"){
			Debug.Log("Player has entered chicken's trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
		}
	}

void OnCollisionEnter(Collision other){
	if(other.gameObject.name == "Player"){
		/* Destroy(gameObject); */
		//Add points to score.
		//scoreManager.AddPoints(points);
		//Send chicken to chicken pen.
		transform.position = chickenPen.position;
		transform.rotation = chickenPen.rotation;
	}
}
	// Update is called once per frame
	void Update () {
		
	}
}
