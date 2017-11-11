using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;	

public class EarthTextScript : MonoBehaviour {

	string myTxt ;
	public Text textBox ;

	// Use this for initialization
	void Start () {
		if (gameObject.name == "Mercury") {
			
		} else if (gameObject.name == "Venus") {
			
		} else if (gameObject.name == "Earth") {
			myTxt = "Earth is a Good\nPlanet";
		} else if (gameObject.name == "Mars") {

		} else if (gameObject.name == "Jupiter") {

		} else if (gameObject.name == "Saturn") {

		} else if (gameObject.name == "Uranus") {

		} else if (gameObject.name == "Neptune") {

		} else if (gameObject.name == "Pluto") {

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
