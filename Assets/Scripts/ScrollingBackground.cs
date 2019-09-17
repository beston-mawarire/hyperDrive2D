using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

	public float speed = -2f;//we made it negative because we want it to scroll down
	
	// Update is called once per frame
	void Update () {
		//the deltaTime is the last time this Update() was run
		transform.Translate(0f, speed * Time.deltaTime, 0f);
		if (transform.position.y <= -30f)//if it's scrolled past it's height
		{//												|
			transform.Translate(0f, 60f,0f);// then we want to mve it back to the top
			GameManager.Instance.SetMeteorSpeed();
			if (MeteoriteCreator.Instance.minCreateDelay >= 0.1)
			{
				MeteoriteCreator.Instance.minCreateDelay -= 0.1f;
			}
			if (MeteoriteCreator.Instance.maxCreateDelay >= 0.3)
			{
				MeteoriteCreator.Instance.maxCreateDelay -= 0.2f;
			}
		}
	}
}
