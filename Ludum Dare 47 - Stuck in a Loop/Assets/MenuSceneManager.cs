using System.Collections;
using System.Collections.Generic;
//using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuSceneManager : MonoBehaviour {

	[SerializeField] GameObject playerNumUI;
	[SerializeField] GameObject difficultyUI;
 
	
	void Start() {
        
    }


    void Update() {
        
    }


	public void SelectDifficulty(int difficulty) {
		if (difficulty == 1) {

		}
		else if (difficulty == 2) {

		}
		else if (difficulty == 3) {

		}
	}


	public void OpenPlayerNumUI() {
		playerNumUI.SetActive(true);
	}


	public void ClosePlayerNumUI() {
		playerNumUI.SetActive(false);

	}


	public void OpenDifficultyUI() {
		difficultyUI.SetActive(true);
	}


	public void CloseDifficultyUI() {
		difficultyUI.SetActive(false);
	}


	public void LoadGameScene () {
		SceneManager.LoadScene(1);
	}


	public void Quit () {
		print("Quit");
		Application.Quit();
	}
}
