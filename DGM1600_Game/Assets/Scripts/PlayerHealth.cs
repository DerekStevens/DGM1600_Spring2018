using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public const int maxHealth = 100;
	public int currentHealth = maxHealth;

	public Text hp;
	public Text maxHP;
	public Transform loseHUD;
	public Transform PlayerCamera;
	public Transform Shooter;

	void Start () {
		loseHUD.gameObject.SetActive(false);
	}
	void Update () {
		hp.text = currentHealth.ToString();
		maxHP.text = maxHealth.ToString();
	}

	public void TakeDamage(int amount){
		currentHealth -= amount;
		if(currentHealth <= 0){
			currentHealth = 0;
			loseHUD.gameObject.SetActive(true);
			Time.timeScale = 0;
			PlayerCamera.GetComponent<CamMouseLook>().enabled = false;
			Shooter.GetComponent<Shoot>().enabled = false;
			Cursor.lockState = CursorLockMode.None;
			print("You're Dead! Game Over!");
		}
	}
}
