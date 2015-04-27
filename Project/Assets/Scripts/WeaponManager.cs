using UnityEngine;
using System.Collections;

public class WeaponManager : MonoBehaviour 
{
	public static int Weapon = 1;

	public static int dmgBoost;
	
	public static bool isBoosted = false;
	
	// Use this for initialization
	void Start () 
	{
		Weapon = 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown("1"))
		{
			if(shoot.hasHandgun)
			{
				if(Weapon != 1)
				{
					Weapon = 1;
					WeaponState();
				}else
					return;
			}

			
		}
		
		if(Input.GetKeyDown("2"))
		{

			if(shoot.hasShotGun)
			{
				if(Weapon != 2)
				{
					Weapon = 2;
					WeaponState();
				}else
					return;
			}
		}

		if(Input.GetKeyDown("3"))
		{
			
			if(shoot.hasAK)
			{
				if(Weapon != 3)
				{
					Weapon = 3;
					WeaponState();
				}else
					return;
			}
		}

		if(Input.GetKeyDown("4"))
		{
			
			if(shoot.hasRocket)
			{
				if(Weapon != 4)
				{
					Weapon = 4;
					WeaponState();
				}else
					return;
			}
		}

	}

	public void StartDamageBoost(float bTime)
	{
		//print("StartDamageBoost " + bTime);
		isBoosted = true;
		
		shoot.shotgunDamage += dmgBoost;
		shoot.rifleDamage += dmgBoost;
		//print ("shotgun " + shoot.shotgunDamage);
		StartCoroutine (DamageBoost (bTime));
	}

	IEnumerator DamageBoost(float t)
	{
		/*isBoosted = true;
		
		shoot.shotgunDamage += dmgBoost;
		shoot.rifleDamage += dmgBoost;
		print ("shotgun " + shoot.shotgunDamage + t);
		*/
		//print ("routine started");
		yield return new WaitForSeconds(t);
		shoot.shotgunDamage -= dmgBoost;
		shoot.rifleDamage -= dmgBoost;
		isBoosted = false;
		//print ("shotgun " + shoot.shotgunDamage);
		

	}
	
	private void WeaponState()
	{
		switch(Weapon)
		{
			case 1:
				print("weapon ONE equipped");
				break;
			case 2:
				print("weapon TWO equipped");
				break;
			case 3:
				print("weapon THREE equipped");
				break;
			case 4:
				print("weapon FOUR equipped");
				break;
			default:
				print ("Weapon Error");
				break;
		}
	}
}
