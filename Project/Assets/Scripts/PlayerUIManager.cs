using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerUIManager : MonoBehaviour 
{
	public Text ammoText;
	public Text healthText;
	public Text armorText;
	public Text waveText;
	public Text scoreText;
	public Text endScore;


	// Use this for initialization
	void Start () 
	{

		armorText.text = ("Armor: " + PlayerHealth.playerArmor);
		ammoText.text = ("Ammo: " + (0));
		healthText.text = ("Health: " + PlayerHealth.playerHealth);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(WeaponManager.Weapon == 1)
		{
			ammoText.text = (ammoText.text = ("Ammo: " + PlayerHealth.rifleAmmo));
		}
		else if(WeaponManager.Weapon == 2)
		{
			ammoText.text = (ammoText.text = ("Ammo: " + PlayerHealth.shotGunAmmo));
		}
		else if(WeaponManager.Weapon == 3)
		{
			ammoText.text = (ammoText.text = ("Ammo: " + PlayerHealth.rifleAmmo));
		}
		else if(WeaponManager.Weapon == 4)
		{
			ammoText.text = (ammoText.text = ("Ammo: " + PlayerHealth.rocketAmmo));
		}
			

		endScore.text = ("Your Score is " + PlayerHealth.scoreInt);
		armorText.text = ("Armor: " + PlayerHealth.playerArmor);
		healthText.text = ("Health: " + PlayerHealth.playerHealth);
		waveText.text = ("Enemies: " + PlayerHealth.waveInt);
		scoreText.text = ("Score: " + PlayerHealth.scoreInt);
	}
	
}
