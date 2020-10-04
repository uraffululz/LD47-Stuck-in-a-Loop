using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	int numberOfPlayers;
 
	
	void Start() {
        Time.timeScale = 1;
    }


    void Update() {
        
    }


	public void SetNumberOfPlayers(int buttonNum) {
		numberOfPlayers = buttonNum;
	}
}
