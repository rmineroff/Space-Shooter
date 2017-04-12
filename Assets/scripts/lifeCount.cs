using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class lifeCount : MonoBehaviour {
	public static Text lifeText;
	private  static int life;
	public static Rigidbody player;

	// Use this for initialization
	void Start () {
		life = 3;
		lifeText = GetComponent<Text> ();
		SetLife ();
		//scoreText.position = new Vector3 (0, 0, 0);
	}

	public static void Hit() {
		if (life > 0) {
			life -= 1;
			SetLife ();
		} else {
			SceneManager.LoadScene ("End");
		}
	}

	public static void SetLife() {
		lifeText.text = "Lives left: " + life.ToString();
		PlayerMovement.PlayerDeath ();
	}
}
