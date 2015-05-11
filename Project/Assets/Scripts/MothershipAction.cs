using UnityEngine;
using System.Collections;

public class MothershipAction : MonoBehaviour 
{
	public Transform startMarker;
	public Transform endMarker;
	public float speed = 1.0F;
	private float startTime;
	private float journeyLength;
	
	
	public GameObject theBoss;
	public Transform theSpawnLoc;
	private bool bossActive = false;
	
	
	
	// Use this for initialization
	void Start () 
	{
		
		startMarker = GameObject.Find("MothershipSpawn").transform;
		endMarker = GameObject.Find("MothershiplerpLoc").transform;
		theSpawnLoc = GameObject.Find("BossSpawnLoc").transform;
		
		startTime = Time.time;
		journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;
		transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
		
		if(transform.position == endMarker.transform.position)
		{
			if(!bossActive)
			{
				if(PlayerHealth.scoreInt >= 5000)
				{
					
					GameObject bossClone = Instantiate(theBoss) as GameObject;
					
					bossClone.transform.position = theSpawnLoc.transform.position;
					
					bossActive = true;
				}
			}
		}
	}
}
