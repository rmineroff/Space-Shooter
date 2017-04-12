using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour {
	
	public static Rigidbody enemy;
	Vector2 movement;
	private GameObject ufo;

	// Use this for initialization
	void Start () {
		
		enemy = GetComponent <Rigidbody> ();
		if (enemy.position.x > 0)
			movement = new Vector2 (-1, 0);
		else if (enemy.position.x < 0)
			movement = new Vector2 (1, 0);

		enemy.velocity = movement;
				
			
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x >= 20) {
			Destroy (this.gameObject);
		} else if (transform.position.x <= -20) {
			Destroy (this.gameObject);
		}
	}
}
