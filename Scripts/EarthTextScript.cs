﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarthTextScript : MonoBehaviour {

	public string myTxt ;
	public Text textBox ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void changeText(){
		textBox.text = myTxt.Replace("\\n" , "\n");
	}
	public void removeText(){
		textBox.text = "" ;
	}
}
