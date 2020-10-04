using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {

	[SerializeField] Camera mainCam;
	[SerializeField] GameObject wheel;
	[SerializeField] GameObject chargeObj;
	Color chargeColor;

	[SerializeField] GameSceneManager GameMan;
	[SerializeField] SceneUIManager UIMan;

	//Vector3 newSpeed;

	Rigidbody rb;

	[SerializeField] KeyCode assignedKey1;
	[SerializeField] KeyCode assignedKey2;
	bool canPressKey1;
	bool canPressKey2;
	[SerializeField] Button onScreenButton1;
	[SerializeField] Button onScreenButton2;

	float moveSpeed = 2f;
	[SerializeField] float currentSpeed;
	float speedMax = 1f;

	//float lookSpeed = 3f;


	
	void Start() {
        rb = GetComponent<Rigidbody>();
		chargeColor = new Color(0, 0 , 0);

		canPressKey1 = true;
		canPressKey2 = true;

    }


	void Update () {
		if (GameMan.playing){
			if (canPressKey1 && Input.GetKeyDown(assignedKey1) || canPressKey2 && Input.GetKeyDown(assignedKey2)) {
				if (currentSpeed < speedMax) {
					currentSpeed += moveSpeed * Time.deltaTime;
				}
				else {
					currentSpeed = speedMax;
				}
			
				if (canPressKey1) {
					canPressKey1 = false;
					canPressKey2 = true;
					onScreenButton1.interactable = false;
					onScreenButton2.interactable = true;
				}
				else {
					canPressKey1 = true;
					canPressKey2 = false;
					onScreenButton1.interactable = true;
					onScreenButton2.interactable = false;
				}
			}
			else {
				if ((float) System.Math.Round(currentSpeed, 2) > 0.00) {
					currentSpeed -= (currentSpeed * Time.deltaTime) / 2;
				}
				else {
					currentSpeed = 0;
				}
			}
			//GetComponent<Animator>().SetFloat("Speed", currentSpeed);

			wheel.transform.Rotate(-wheel.transform.right, (float) System.Math.Round(currentSpeed, 2));

			GameMan.PlayerChargeColor(currentSpeed * .002f);
		}
		else {
			//wheel.transform.Rotate(-wheel.transform.right, 0);

			GameMan.PlayerChargeColor(0);
		}
	}


	void LateUpdate() {
	}


	


	


	


	
}
