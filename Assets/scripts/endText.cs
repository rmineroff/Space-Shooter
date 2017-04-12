using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class endText : MonoBehaviour {
	public static Text endingText;
	int score;
	// Use this for initialization
	void Start () {
		endingText = GetComponent<Text> ();
		score = scoreCount.score;
		endingText.text = "Your final score was: " + score.ToString();
	}
	
	// Update is called once per frame

}
