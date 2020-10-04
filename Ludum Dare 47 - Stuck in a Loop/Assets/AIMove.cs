using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour {

	[SerializeField] GameObject wheel;
	[SerializeField] GameObject chargeObj;

	[SerializeField] GameSceneManager GameMan;

	[SerializeField] float wheelSpeed;



    void Start() {
        //Determine wheelSpeed based on difficulty
		
		/*Easy*/ wheelSpeed = -20;
		/*Medium*/ 
		/*Hard*/ 
    }


    void Update() {
		if (GameMan.playing) {

			wheel.transform.Rotate(-wheel.transform.right, Time.deltaTime * wheelSpeed);

			GameMan.AIChargeColor(Time.deltaTime * .03f);
		}
		else {
			//wheel.transform.Rotate(-wheel.transform.right, 0);

			GameMan.AIChargeColor(0);
		}
    }
}
