using UnityEngine;
using System.Collections;

public class BossSpawn : MonoBehaviour 
{
	public GameObject theShip;
	public Transform theSpawnLoc;
	private bool shipActive = false;
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(!shipActive)
		{
			if(PlayerHealth.scoreInt >= 5000)
			{
				
				GameObject shipClone = Instantiate(theShip) as GameObject;
				
				shipClone.transform.position = theSpawnLoc.transform.position;
				
				shipActive = true;
			}
		}
		
	}
}
