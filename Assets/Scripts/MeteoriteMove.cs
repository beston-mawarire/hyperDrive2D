using UnityEngine;

public class MeteoriteMove : MonoBehaviour {

	public Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		rb2d.velocity = new Vector2(0f, GameManager.Instance.meteorSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
