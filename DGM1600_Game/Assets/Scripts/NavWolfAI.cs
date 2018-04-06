using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavWolfAI : MonoBehaviour {

	// Public Variables
	public Transform player; // Location of player.
	public float speed;
	// Wander
	public float wanderRadius; // Radius where the wolf will wander.
	public float wanderTimer; // How long the wolf will wander before changing direction.
	// Detection
	public float alertDist; // Distance at which the wolf is aware of the player.
	public float attackDist; // Distance at which the wolf attacks.
	// Private
	private Animator state;
	private Vector3 direction; // Vector3 (a point in space)
	private Transform target; // What the wolf is going to follow.
	private UnityEngine.AI.NavMeshAgent agent; // Wolf agent
	private float timer;
	private float distance; // For calculating distance between the player and the wolf.

	void OnEnable () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		timer = wanderTimer;
	}

	void Start () {
		state = GetComponent<Animator>();
		distance = Vector3.Distance(player.position, transform.position); // Where is the play in relation the wolf?
	}

	void Update () {
		//Alert
		if(distance < alertDist && distance > attackDist){
			print("Wolf sees player");
			state.SetBool("isFollowing",true);
			state.SetBool("isWandering",false);
			state.SetBool("isAttacking",false);
		}
		// Attacking
		else if(distance <= alertDist){
			print("");
			direction = player.position - transform.position;
			direction.y = 0;

			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction),0.09f*Time.deltaTime);

			transform.Translate(Vector3.forward*speed*Time.deltaTime);

			state.SetBool("isFollowing",true);
			state.SetBool("isAttacking",false);
			state.SetBool("isWandering",false);

			if(direction.magnitude <= attackDist){
				state.SetBool("isFollowing",false);
				state.SetBool("isAttacking",true);
				state.SetBool("isWanering",false);
			}
		}

		// Wandering
		else if(distance > alertDist){
			timer += Time.deltaTime;

				// state.SetBool("isFollowing",false);
				// state.SetBool("isAttacking",false);
				// state.SetBool("isWandering",true);
			
			if (timer >= wanderTimer){
				Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
				agent.SetDestination(newPos);
				timer = 0;
			}
		}

	}

	public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask){
		Vector3 randDirection = Random.insideUnitSphere * dist;

		randDirection += origin;
		
		UnityEngine.AI.NavMeshHit navHit;

		UnityEngine.AI.NavMesh.SamplePosition (randDirection, out navHit, dist, layermask);

		return navHit.position;
	}

}
