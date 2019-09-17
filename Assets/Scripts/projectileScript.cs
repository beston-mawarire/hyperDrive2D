using UnityEngine;

public class projectileScript : MonoBehaviour {

	public float speed = 10f;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = new Vector2 (0f, speed);
	}
	
	/// <summary>
	/// Sent when an incoming collider makes contact with this object's
	/// collider (2D physics only).
	/// </summary>
	/// <param name="other">The Collision2D data associated with this collision.</param>
	void OnCollisionEnter2D(Collision2D other)
	{
		Destroy(other.gameObject);//destroy what I hit
		// GameManager.Instance.SetScore();
		Destroy(gameObject);
	}
}
