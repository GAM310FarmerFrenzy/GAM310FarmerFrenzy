using UnityEngine;
using System.Collections;


public class Pickups : MonoBehaviour 
{
	public int shotGunAmmo;
	public int rifleAmmo;
	public int rocketAmmo;
	public int healthAmount;
	public int armorAmmount;
	public int tempDamage;
	public float bDamageTime;
	public float invulnTime;
	public bool respawns;
	public float respawnTimer;
	private MeshRenderer thisMesh;
	private BoxCollider thisColl;
	// Use this for initialization
	void Start () 
	{
		thisMesh = gameObject.GetComponent<MeshRenderer>();
		thisColl = gameObject.GetComponent<BoxCollider>();
		if(respawns)
		{
			//MeshRenderer thisMesh = gameObject.GetComponent<MeshRenderer>();
			thisMesh.enabled = false;
			thisColl.enabled = false;
			StartCoroutine("SpawnTime", respawnTimer);
		}
	}
	
	IEnumerator SpawnTime(float respawnTime)
	{
		//print ("THE PICKUP sPAWN TIMER IS ACTIVE");
		yield return new WaitForSeconds(respawnTime);
		print ("THE PICKUP sPAWN TIMER IS ACTIVE");
		thisMesh.enabled = true;
		thisColl.enabled = true;
		
		
	}
	
	
	
	// Update is called once per frame
	void Update () 
	{

	}

	private void OnTriggerEnter(Collider player)
	{
		if(player.gameObject.tag == "Player")
		{
			print ("Player picked up the item");
			//Destroy (gameObject);
			PlayerHealth.shotGunAmmo += shotGunAmmo;
			PlayerHealth.rifleAmmo += rifleAmmo;
			PlayerHealth.playerHealth += healthAmount;
			PlayerHealth.playerArmor += armorAmmount;
			PlayerHealth.rocketAmmo += rocketAmmo;
			
			GameObject wManager = GameObject.FindGameObjectWithTag ("Player");
			
			if(!WeaponManager.isBoosted)
			{
				//GameObject wManager = GameObject.FindGameObjectWithTag ("Player");
				WeaponManager.dmgBoost = tempDamage;
				wManager.SendMessage("StartDamageBoost", bDamageTime);
			}
			
			//print (PlayerHealth.invuln);
			if(!PlayerHealth.invuln)
			{
				wManager.SendMessage("startInvTimer", invulnTime);
			}
			//wManager.SendMessage("startInvTimer", invulnTime);
			
			
			
			
			
			if(respawns)
			{
				thisMesh.enabled = false;
				thisColl.enabled = false;
				StartCoroutine("SpawnTime", respawnTimer);
			}
			

		}

	}
}
