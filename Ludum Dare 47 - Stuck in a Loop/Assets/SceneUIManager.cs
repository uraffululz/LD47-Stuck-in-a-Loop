using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneUIManager : MonoBehaviour {

	[SerializeField] GameObject winUI;
	[SerializeField] Text winUIText;
	[SerializeField] GameObject chargeText;
	[SerializeField] GameObject timerText;
	[SerializeField] GameObject quitButton;


	
	void Start() {
        
    }


    void Update() {
        
    }


	public void EndGameUI(int winner) {
		winUI.SetActive(true);
		chargeText.SetActive(false);
		timerText.SetActive(false);
		quitButton.SetActive(false);

		if (winner == 1) {
			winUIText.text = "BLUE WINS";
		}
		else {
			winUIText.text = "RED WINS";
		}

		
		Time.timeScale = 0;
		GetComponent<GameSceneManager>().playing = false;

		//print(Time.timeScale);
	}


	public void ExitToMainMenu() {
		SceneManager.LoadScene(0);
	}


	public void QuitGame() {
		print("Quit");
		Application.Quit();
	}
}
