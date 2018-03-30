using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public int damage = 1;
	public int time = 5;

	// Use this for initialization
	void Start () {
		StartCoroutine(DestroyBullet());
	}
	
	void OnCollisionEnter(Collision other)
	{
		var hit = other.gameObject;
		var health = hit.GetComponent<WolfHealth>();

		if(health != null){
			health.TakeDamage(damage);
		}
	}
	// Update is called once per frame
	// void Update () {
		
	// }

	IEnumerator DestroyBullet(){
		yield return new WaitForSeconds(time);
		Destroy(gameObject);
	}
}
