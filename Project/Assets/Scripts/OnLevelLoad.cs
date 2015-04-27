using UnityEngine;
using System.Collections;

public class OnLevelLoad : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		PlayerHealth.playerHealth = 100;
		PlayerHealth.waveInt = 0;
		PlayerHealth.playerArmor = 0;
		PlayerHealth.rifleAmmo = 75;
		PlayerHealth.shotGunAmmo = 30;
		PlayerHealth.rocketAmmo = 10;

		print ("ON LEVEL LOAD");
		PauseMenu.Paused = false;
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
