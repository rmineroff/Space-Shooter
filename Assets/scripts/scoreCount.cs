using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreCount : MonoBehaviour {
	public static Text scoreText;
	public  static int score;
	private static AudioSource source;
	public static AudioClip clip;

	// Use this for initialization
	void Start () {
		score = 0;
		scoreText = GetComponent<Text> ();
		SetScore ();
		source = GetComponent<AudioSource> ();
		//scoreText.position = new Vector3 (0, 0, 0);
	}

	public static void AddScore() {
		source.Play ();
		score += 10;
		SetScore();
	}

	public static void SetScore() {
		scoreText.text = "Score: " + score.ToString();
	}
}
