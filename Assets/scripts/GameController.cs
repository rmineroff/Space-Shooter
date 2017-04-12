using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public static GUIText scoreText;
	private static int score;

	// Use this for initialization
	void Start () {
		score = 0;
		addScore ();
	}

	public static void addScore () {
		score += 10;
		updateScore ();
	}

	public static void updateScore ()
	{
		scoreText.text = "Score: " + score;
	}
}