using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
	public Vector2 velocity = new Vector2(-4, 0);

	public float range = 1;
	public float offset = 20.0f;



	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = velocity;
		//100% copy paste, ger mina hinder random höjd för lite mer action
		transform.position = new Vector3(transform.position.x + offset, transform.position.y - range * Random.value, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () 
	{
	if (transform.position.x <= -26) 
		Destroy (gameObject);

	}

	void OnTriggerEnter2D( Collider2D aCollider )
	{
		if (aCollider.tag == "Player") 
		{
			ScoreManager.Score+=1;
		}
	}
}
