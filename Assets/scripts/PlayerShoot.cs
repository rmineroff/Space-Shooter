using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
	bool allowfire = true;
	public Object red, blue;
	float bullet;
	void Update () 
	{
		if(Input.GetKey(KeyCode.A) && allowfire == true)
		{
			bullet = 1f;
			StartCoroutine (Fire ());

		}
		else if(Input.GetKey(KeyCode.S) && allowfire == true)
		{
			bullet = 2f;
			StartCoroutine(Fire());

		}

	}



	private IEnumerator Fire() {
		allowfire = false;

		if (bullet == 1f )
			Instantiate(red, new Vector3 ((PlayerMovement.person.position.x + 0.5f), (PlayerMovement.person.position.y) + 1, 10), transform.rotation);

		else if (bullet == 2f)
			Instantiate(blue, new Vector3 ((PlayerMovement.person.position.x + 0.5f), PlayerMovement.person.position.y + 1, 10), transform.rotation);
			yield return new WaitForSeconds(0.5f);
					allowfire = true;
	}
}
