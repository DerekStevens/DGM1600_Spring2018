using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float timerLeft = 120.0f;
	public Text text;
	bool clock;
	private float mins;
	private float secs;

	public Transform loseHUD;
	public Transform PlayerCamera;
	public Transform Shooter;

	void Update () {
		if (timerLeft > 0 && clock == false) {
			clock = true;
			StartCoroutine(Wait());
		}

		if (timerLeft <= 0) {
						loseHUD.gameObject.SetActive(true);
			Time.timeScale = 0;
			PlayerCamera.GetComponent<CamMouseLook>().enabled = false;
			Shooter.GetComponent<Shoot>().enabled = false;
			Cursor.lockState = CursorLockMode.None;
		}
	}

	IEnumerator Wait() {
		timerLeft -= 1;
		UpdateTimer();
		yield return new WaitForSeconds(1);
		clock = false;
	}

	void UpdateTimer() {
		int min = Mathf.FloorToInt(timerLeft / 60);
		int sec = Mathf.FloorToInt(timerLeft % 60);
		text.GetComponent<UnityEngine.UI.Text>().text = min.ToString("00") + ":" + sec.ToString("00");
	}
}  
