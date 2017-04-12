using UnityEngine;
using System.Collections;

public class redBullet : MonoBehaviour {
	private Rigidbody bullet; 
	Vector2 movement = new Vector2 (0, 7f);
	public GameObject explosion;
	private static AudioSource source;
	public AudioClip clip;

	// Use this for initialization
	void Start () {
		bullet = GetComponent<Rigidbody> ();
		bullet.velocity = movement;
		source = GetComponent<AudioSource> ();
	


	}
	
	// Update is called once per frame
	void Update () {
		if (bullet.position.y >= 6)
			Destroy(this.gameObject);
			
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == "blue enemy(Clone)")
			Destroy (this.gameObject);
		if(col.gameObject.name == "red enemy(Clone)")
		{
			source.Play ();
			Instantiate(explosion, new Vector3 (bullet.position.x, (bullet.position.y) + 0.5f), transform.rotation);
			Destroy(col.gameObject);
			Destroy(this.gameObject);
			scoreCount.AddScore ();
		}

	}

}
