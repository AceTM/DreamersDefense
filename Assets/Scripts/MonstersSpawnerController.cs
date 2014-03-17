using UnityEngine;
using System.Collections;

public class MonstersSpawnerController : MonoBehaviour {

	public GameObject monster;
	private float timeElapsed = 0;
	private float startSpawnedPeriod = 5.0f;
	private float spawnedSpeed = 1.0f;
	private float increasingSpawnedRatio = 0.1f;
	private int spawnedSpeedIncreasingCycle = 0;

	// Use this for initialization
	void Start () {
		SpawnMonster();
	}
	
	// Update is called once per frame
	void Update () {
		if (timeElapsed >= spawnedPeriod()) {
			SpawnMonster();
			timeElapsed = 0;
		}

		timeElapsed += Time.deltaTime;
	}

	private void SpawnMonster () {
		Instantiate(monster, transform.position, Quaternion.identity);
	}

	private float spawnedPeriod () {
		int cycle = (int) Time.time / (int) startSpawnedPeriod;
		if (cycle > spawnedSpeedIncreasingCycle) {
			spawnedSpeed *= 1 + increasingSpawnedRatio;
			spawnedSpeedIncreasingCycle = cycle;
		}
		return startSpawnedPeriod / spawnedSpeed;
	}
}
