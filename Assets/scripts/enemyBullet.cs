using UnityEngine;
using System.Collections;

public class enemyBullet : MonoBehaviour {
	Rigidbody bullet; 
	Vector2 movement = new Vector2 (0, -4f);
	// Use this for initialization
	void Start () {
		bullet = GetComponent<Rigidbody> ();
		bullet.velocity = movement;


	}

	// Update is called once per frame
	void Update () {
		if(bullet.position.y <= -7)
		Destroy(this.gameObject);
		

	}
	void OnTriggerEnter(Collider col)
	{
		
		if(col.gameObject.name == "player")
		{
			Destroy(this.gameObject);
			lifeCount.Hit ();

		}

	}
}
