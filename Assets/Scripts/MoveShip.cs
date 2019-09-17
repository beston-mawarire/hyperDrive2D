using System.Collections;
using UnityEngine;

public class MoveShip : MonoBehaviour {

	private Rigidbody2D rb;
	public float speed = 15f;

	//prevent player from moving off edges of map
	public float playAreaWidth = 8f;

	public GameObject bullet;

	public float bulletReload = 0.25f;//time between bullet fire

	private float elapsedTime = 0;

	public AudioSource bulletSound;

	
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	void Update()
	{
		elapsedTime += Time.deltaTime;

		float y = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

		Vector2 newPosition = rb.position + Vector2.right * y;

		newPosition.x = Mathf.Clamp(newPosition.x, -playAreaWidth, playAreaWidth);
		//Mathf.Clamp() limits 
		// Mathf.Clamp();
		//moveposition object tospecific collision checking for collision along the way
		rb.MovePosition(newPosition);

		if(Input.GetButtonDown("Jump") && elapsedTime >= bulletReload)
		{
			Debug.Log("Jump pressed!");
			Vector3 spawnBulletPosition = transform.position;//spawn and set bullet position sameplace as the the ship
			spawnBulletPosition += new Vector3(0f, 1.2f, 0f);//move bullet just a little infron of the ship 
			Instantiate(bullet, spawnBulletPosition, Quaternion.identity);
			bulletSound.Play();// a
			elapsedTime = 0f;
		}
	}

	/// <summary>
	/// Sent when another object enters a trigger collider attached to this
	/// object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerEnter2D(Collider2D other)
	{
		GameManager.Instance.PlayerDied();
		Destroy(gameObject);
	}
}
