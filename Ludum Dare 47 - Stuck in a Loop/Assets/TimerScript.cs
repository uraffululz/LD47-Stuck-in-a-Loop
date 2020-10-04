using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

	float startTime = 11;
	float currentTime;

	float psychTimerStart = 2;
	float currentPsychTimer;

	[TextArea(2, 4, order = 0)]
	[SerializeField] string[] psyches;
	int currentPsych;
	
	
	void Start() {
        currentTime = startTime;
		currentPsychTimer = psychTimerStart;
    }


    void Update() {
		if (currentTime > 1) {
			GetComponent<Text>().fontSize = 50;

			currentTime -= Time.deltaTime;

			GetComponent<Text>().text = (((int)currentTime).ToString() /*+ ":" + currentTime / 60*/);
		}
		else {
			GetComponent<Text>().fontSize = 30;
			currentTime = 0;


			if (currentPsychTimer > 0) {
				if (currentPsych < psyches.Length) {
					currentPsychTimer -= Time.deltaTime;
				}
				else {
					//Restart/End the loop
					currentPsych = 0;
				}

				GetComponent<Text>().text = psyches[currentPsych];
			}
			else {
				currentPsych++;

				currentTime = startTime;
				currentPsychTimer = psychTimerStart;
			}
		}

		//GetComponent<Text>().text = (currentTime + ":" + currentTime / 60);
	}
}
