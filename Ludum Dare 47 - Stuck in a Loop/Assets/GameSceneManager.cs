using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneManager : MonoBehaviour {

	SceneUIManager UIMan;

	public GameObject chargeObj;
	public Color chargeColor;

	//bool inputDisabled;

	public bool playing;

	
	void Start() {
        UIMan = GetComponent<SceneUIManager>();

		//inputDisabled = false;
		playing = true;
    }


    void LateUpdate() {
		chargeObj.GetComponent<MeshRenderer>().material.color = chargeColor * 2.5f;

		EvaluateChargeColor();
	}


	public void PlayerChargeColor (float changeRate) {
		chargeColor.b += changeRate;
		chargeColor.r -= changeRate;
	}


	public void AIChargeColor (float AIChangeRate) {
		chargeColor.b -= AIChangeRate;
		chargeColor.r += AIChangeRate;
	}


	void EvaluateChargeColor () {
		print(chargeColor.b);

		if (chargeColor.b >= 1.5f) {
			print("BLUE WINS");

			UIMan.EndGameUI(1);
		}
		else if (chargeColor.r >= 1.5f) {
			print("RED WINS");

			UIMan.EndGameUI(2);
		}
	}
}
