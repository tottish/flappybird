using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public Vector2 jumpForce = new Vector2(0,300);
	float deathTimer;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp("space"))
		{
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(jumpForce);
		}
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
		{
			Die();
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		Die();
	}
	//Lite hjälp av felix så att man får se spelaren dö i 1,75 sekunder extra #cred2felix
	void Die()
	{
		GetComponent<Player> ().enabled = false;
		Destroy (gameObject,1.25f);

	}
}
