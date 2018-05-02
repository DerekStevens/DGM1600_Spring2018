using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

	public static int score;

	public int winScore;
	public Text text;
	public Transform winHUD;
	public Transform PlayerCamera;
	public Transform Shooter;

	void Awake () {
		Time.timeScale = 1;
	}

	void Start () {
		winHUD.gameObject.SetActive(false);
		text = text.GetComponent<Text>();
			score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(score < 0) {
			score = 0;
		}
			text.text = " " + score;
		
			// If the player win display win text
			if(score >= winScore) {
				print("Win Score Reached = " + score);
				winHUD.gameObject.SetActive(true);
				Time.timeScale = 0;
				PlayerCamera.GetComponent<CamMouseLook>().enabled = false;
				Shooter.GetComponent<Shoot>().enabled = false;
				Cursor.lockState = CursorLockMode.None;

				if(Input.GetKeyDown(KeyCode.Escape)) {
					SceneManager.LoadScene(0);
				}
			}


	}

	public static void AddPoints(int pointsToAdd){
		score += pointsToAdd;
	}

	public void Reset(){
		score = 0;
	}
}