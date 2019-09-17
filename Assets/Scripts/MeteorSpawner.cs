using UnityEngine;

public class MeteorSpawner : MonoBehaviour {
	//Transform we use when we wana us any position checks, any rotations or anything like that
	public Transform[] spawningPoints;

	public GameObject asteroidBelt;

	private float spawnTimer = 2f;

	public float timeBetweenSpawns = 1f;
	// Use this for initialization
	void Update () {
		if (Time.time >= spawnTimer)
		{
			SpawnRocks();
			spawnTimer = Time.time + timeBetweenSpawns;
		}
	}

	void SpawnRocks ()
	{
		int randomPoint = Random.Range(0, spawningPoints.Length);

		for (int i = 0; i < spawningPoints.Length; i++)
		{
			if (randomPoint != i)
			{
				Instantiate(asteroidBelt, spawningPoints[i].position, Quaternion.identity);//Quaternion.identity means dont do any thing to the object. i.e dont rotate
			}
		}
	}
}
