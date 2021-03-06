﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfHealth : MonoBehaviour {

	public int currentHealth;
	public int maxHealth = 3;
	public Transform spawnPoint;
	public int points;

	void Start () {
		currentHealth = maxHealth;
	}

	public void TakeDamage(int amount){
		currentHealth -= amount;
		if(currentHealth <+ 0){
			// Keep score at zero
			currentHealth = 0;
			print("Wolf is Dead!");
			// Add points to score for killing wolf
			ScoreManager.AddPoints(points);
			// Move wolf to spawn point for restart
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;
			// Reset Wolf health
			currentHealth = maxHealth;
		}
	}


}