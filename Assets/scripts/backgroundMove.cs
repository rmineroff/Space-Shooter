using UnityEngine;
using System.Collections;

public class backgroundMove : MonoBehaviour {
	public Rigidbody2D rb;
	public float rbPosition = 12.9f;
	Vector3 movement = new Vector3(0 ,-1);



	// Use this for initialization
	void Start () {
		rb.AddForce(movement);
	}
	void Update(){
		if (rb.position.y <= -13)
			transform.position =  new Vector3(0, rbPosition, 15);
	}
}
