using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScoreOnLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameInformation.Score = 0;	
	}
	
}
