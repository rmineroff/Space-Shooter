﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class tutorialText : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space))
			SceneManager.LoadScene ("Game");
	}
}
