using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;	

public class EarthTextScript : MonoBehaviour {

	string myTxt ;
	public Text textBox ;

	// Use this for initialization
	void Start () {
		if (gameObject.name == "Earth") {
			myTxt = "Earth is a Good Planet";
		}
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void changeText(){
		textBox.text = myTxt;
	}
	public void removeText(){
		textBox.text = "" ;
	}
}
