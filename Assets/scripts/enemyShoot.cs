using UnityEngine;
using System.Collections;

public class enemyShoot : MonoBehaviour {
	bool allowfire = true;
	public Object green;
	Rigidbody enemy;

	void Start ()
	{
		enemy = GetComponent<Rigidbody> ();
	}

	void Update () 
	{
		if (allowfire == true) {
			allowfire = false;
			StartCoroutine (Fire ());
		}
	}
		

	private IEnumerator Fire() {
		float wait = Random.Range(2.0f, 5.9f);

		Instantiate(green, new Vector3 (enemy.position.x, (enemy.position.y + -1), 0), transform.rotation);

		yield return new WaitForSeconds(wait);
		allowfire = true;
	}
}
