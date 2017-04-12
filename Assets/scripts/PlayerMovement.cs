using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public static Rigidbody person;
	Vector2 up, down, left, right, movement;

	// Use this for initialization
	void Start () {
		person = GetComponent<Rigidbody> ();
		movement = new Vector2 (0, 0);
		up = new Vector2 ( person.velocity.x, 5f);
		down = new Vector2 ( person.velocity.x, -5f);
		left = new Vector2 ( 5f, person.velocity.y);
		right = new Vector2 ( -5f, person.velocity.y);
	
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKeyDown("down"))
			movement += down ;
		if (Input.GetKeyUp ("down"))
			movement -= down;
		if( Input.GetKeyDown("up"))
			movement += up ;
		if (Input.GetKeyUp ("up"))
			movement -= up;
		if( Input.GetKeyDown("left"))
			movement -= left ;
		if (Input.GetKeyUp ("left"))
			movement += left;
		if( Input.GetKeyDown("right"))
			movement -= right ;
		if (Input.GetKeyUp ("right"))
			movement += right;
		
		person.velocity = movement;
			

	}

	public static void PlayerDeath(){
		person.transform.position = new Vector2 (0, -4f);
	}
}
