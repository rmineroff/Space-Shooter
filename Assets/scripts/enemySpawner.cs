using UnityEngine;
using System.Collections;

public class enemySpawner : MonoBehaviour {
	bool spawn = true;
	public Object redEnemy, blueEnemy;
	float wait, enemy;
	Rigidbody spawner;

	void Start()
	{
		spawner = GetComponent<Rigidbody> ();
	}


	void Update () 
	{
		if (spawn == true) {
			StartCoroutine (Spawn());
		}
	}



	private IEnumerator Spawn() {
		spawn = false;
		if (scoreCount.score < 150)
			wait = Random.Range (5.1f, 6.9f);
		else if (scoreCount.score < 300)
			wait = Random.Range (4.1f, 5.9f);
		else
			wait = Random.Range (3.1f, 4.9f);
		yield return new WaitForSeconds(wait);

		enemy = Random.Range (1f, 1000000000f);
		if (enemy <= 500000000f )
			Instantiate(redEnemy, new Vector3 (spawner.position.x, spawner.position.y, 10), transform.rotation);

		else Instantiate(blueEnemy, new Vector3 (spawner.position.x, spawner.position.y, 10), transform.rotation);

		spawn = true;
	}
}
