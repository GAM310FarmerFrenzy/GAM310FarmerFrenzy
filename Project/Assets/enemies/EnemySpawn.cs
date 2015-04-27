/*
 * EnemySpawn.cs
 * 
 * by Ben Stewart
 * 
 * this script makes so it will spawn anything you put into the array*/



using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour 
{

	public GameObject SpawnArea;

	public float spawnTime;
	public float spawnTimeRandom;

	private float spawnTimer;
	
	public int activateSpawnerOnWave = 0;

	public GameObject[] enemyArray;
	/// <summary>
	/// Resets the spawn timer when game starts
	/// </summary>
	private void Start()
	{
		ResetSpawnTimer();

	}
	/// <summary>
	/// timer for how long till the next enemy spawns
	/// </summary>
	private void Update()
	{
		if(activateSpawnerOnWave <= PlayerHealth.waveInt && PlayerHealth.waveInt <= 100)
		{
			spawnTimer -= Time.deltaTime;
			if(spawnTimer <= 0.0f)
			{
				Spawn();
				ResetSpawnTimer();
			}
		}
		
		/*
		spawnTimer -= Time.deltaTime;
		if(spawnTimer <= 0.0f)
		{
			Spawn();
			ResetSpawnTimer();
		}
		*/
	}
	private void ResetSpawnTimer()
	{
		spawnTimer= (float)(spawnTime + Random.Range(0,spawnTimeRandom * 100) / 100.0);

	}
	/// <summary>
	/// spawns the game object	
	/// </summary>
 	private void Spawn()
	{		
			Instantiate(enemyArray[Random.Range(0,enemyArray.Length)],SpawnArea.transform.position,Quaternion.identity);

			PlayerHealth.waveInt += 1;
	}



}
