using UnityEngine;
using System;
using System.Collections;

public class MeteoriteCreator : MonoBehaviour {


	public static MeteoriteCreator Instance;
	public float minCreateDelay = 1f;
	public float maxCreateDelay = 2f;

	// private int timePassed = 0;

	public GameObject meteoritePrefab;

	void Awake()
	{
		if (Instance != null)
		{
			Destroy(gameObject);
		} else
		{
			Instance = this;
		}
	}

	// Use this for initialization
	void Start () {
		SpawnMeteor();
	}
	
	// Update is called once per frame
	/*void FixedUpdate () {
		timePassed = Convert.ToInt32(Time.timeSinceLevelLoad);
		if (timePassed != 0 && timePassed % 10 == 0)
		{
			// Invoke("SpeedUpSpawner", 1);
			// SpeedUpSpawner();
			// StartCoroutine(SpeedUpSpawner());
		}
	}*/

	public void SpawnMeteor ()
	{
		Vector3 spawnPos = new Vector2(UnityEngine.Random.Range(-7,7), 6f);//the 6f is the y position just above the camera
		Instantiate(meteoritePrefab, spawnPos, Quaternion.identity);
		Invoke("SpawnMeteor", UnityEngine.Random.Range(minCreateDelay, maxCreateDelay));
	}

	// IEnumerator SpeedUpSpawner()
	// {
	// 	yield return new WaitForSeconds(1f);

	// 	if (minCreateDelay > 0.1)
	// 	{
	// 		minCreateDelay = minCreateDelay - 0.1f;
	// 	}	
	// 	if (maxCreateDelay > 0.3)
	// 	{
	// 		maxCreateDelay = maxCreateDelay - 0.1f;
	// 	}
	// 	Debug.Log("Wait for ish");
	// }
}
