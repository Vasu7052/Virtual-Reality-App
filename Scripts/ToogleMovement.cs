using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToogleMovement : MonoBehaviour {

	public GameObject cameraObject ;
	public GameObject centerObject ;
	public float revolutionSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void checkToggle(){
		if (gameObject.name == "Pause") {
			stopMovement ();
		} else {
			startMovement ();
		}
	}

	void startMovement(){
		transform.RotateAround (centerObject.transform.position, Vector3.down, 0);
		gameObject.name = "Pause";
	}

	void stopMovement(){
		transform.RotateAround (centerObject.transform.position, Vector3.down, revolutionSpeed * Time.deltaTime);
		gameObject.name = "Start";
	}

}
