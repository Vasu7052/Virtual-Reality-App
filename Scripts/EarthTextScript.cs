using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthTextScript : MonoBehaviour {

	public string myTxt ;
	public Text textBox ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		changeText ();
	}

	void changeText(){
		textBox.text = myText;
	}
}
