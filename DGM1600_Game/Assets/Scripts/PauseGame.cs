using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.Characters.FirstPerson;

public class PauseGame : MonoBehaviour {
	
	public Transform pauseHUD;
	//public Transform Player;

	void Start() {
		pauseHUD.gameObject.SetActive(false);
	}
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)){
			Pause();
		}
	}
	public void Pause() {
		if (pauseHUD.gameObject.activeInHierarchy == false){
				pauseHUD.gameObject.SetActive(true);
				Time.timeScale = 0;
				print("Game Paused");
				//Player.GetComponent<FirstPersonController>().enabled = false;
			}
			else{

			pauseHUD.gameObject.SetActive(false);
			Time.timeScale = 1;
			print ("Game Resumed");
			//Player.GetComponent<FirstPersonController>().enabled = true;
			}
	}
}
