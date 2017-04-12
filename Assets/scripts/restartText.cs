using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restartText : MonoBehaviour {
	public Text restart;
	// Use this for initialization
	void Start () {
		restart = GetComponent<Text> ();
		restart.text = "Press the space bar to try again";

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space))
			SceneManager.LoadScene("Game");
	
	}
}
