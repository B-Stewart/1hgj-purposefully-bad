﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLastScore : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        this.GetComponent<Text>().text = GameInformation.Score.ToString();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
