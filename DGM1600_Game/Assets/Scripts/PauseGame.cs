using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.Characters.FirstPerson;

public class PauseGame : MonoBehaviour {
	
	public Transform pauseHUD;

	public GameObject PlayerCamera;
	public GameObject Shooter;
	private CamMouseLook playerLookScript;
	private Shoot ShootScript;

	void Awake () {
		playerLookScript = PlayerCamera.GetComponent<CamMouseLook>();
	}
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
				Cursor.lockState = CursorLockMode.None;
				print("Game Paused");
				PlayerCamera.GetComponent<CamMouseLook>().enabled = false;
				Shooter.GetComponent<Shoot>().enabled = false;
			}
			else{

			pauseHUD.gameObject.SetActive(false);
			Time.timeScale = 1;
			Cursor.lockState = CursorLockMode.Locked;
			print ("Game Resumed");
			PlayerCamera.GetComponent<CamMouseLook>().enabled = true;
			Shooter.GetComponent<Shoot>().enabled = false;
			}
	}
}
