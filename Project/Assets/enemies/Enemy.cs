using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

	[SerializeField]private int Damage;
	[SerializeField]private int Health;
	[SerializeField]private int Speed;
	[SerializeField]private GameObject player;
	[SerializeField]private NavMeshAgent Agent;
	public bool Range = false;
	[SerializeField]private bool Attacking = false;
	[SerializeField]private bool isAttacking = false;
	public GameObject deathParticle;
	
	public AudioClip enemyDeathSound;
	public AudioClip enemyHitSound;
	
	private AudioSource enemySound;

	private int cDamage;

	public GameObject getHitParticle;


	private void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		Agent = this.GetComponent<NavMeshAgent> ();
		cDamage = Damage;
		GetComponent<NavMeshAgent> ().enabled = false;
		enemySound = GetComponent<AudioSource>();
	}

	public void GetDie()
	{
		Health = 0;
	}

	private void Update()
	{
		if (Attacking == false)
		{
			if (Range == false)
			{
				Agent.SetDestination (player.transform.position);
				Agent.Resume();
			} 
			else 
			{
				Attacking = true;
			}

		} 
		else if(!isAttacking)
		{
			Agent.Stop();
			StartCoroutine(Attack());
		}



		if(Health <= 0)
		{
			Destroy(gameObject);
			if(gameObject.name == "Chicken(Clone)")
			{
				PlayerHealth.scoreInt += 100;

				PlayerHealth.waveInt -= 1;

			}else 
			if(gameObject.name == "Cow(Clone)")
			{
				PlayerHealth.scoreInt += 200;

				PlayerHealth.waveInt -= 1;
			}else 
				if(gameObject.name == "Sheep(Clone)")
			{
				PlayerHealth.scoreInt += 350;
				
				PlayerHealth.waveInt -= 1;
			}else 
				if(gameObject.name == "Pig(Clone)")
			{
				PlayerHealth.scoreInt += 150;
				
				PlayerHealth.waveInt -= 1;
			}

			
			GameObject particle = Instantiate (deathParticle) as GameObject;
			particle.transform.position = gameObject.transform.position;
			particle.transform.rotation = gameObject.transform.rotation;
			
			enemySound.clip = enemyDeathSound;
			enemySound.Play();
			
		}
	}

	public void DamageMe(int dmg)
	{
		Health -= dmg;

		GameObject hitPart = Instantiate (getHitParticle) as GameObject;
		hitPart.transform.position = gameObject.transform.position;
		hitPart.transform.rotation = gameObject.transform.rotation;

		enemySound.clip = enemyHitSound;
		enemySound.Play();


		print ("i was hit");
	}

	IEnumerator Attack()
	{
		isAttacking = true;
		//int remainingHealth = (Damage -= PlayerHealth.playerArmor);
		if(PlayerHealth.invuln == false)
		{
			GameObject.FindWithTag ("Player").SendMessage("HurtParticle");
			if(PlayerHealth.playerArmor != 0)
			{
				if(PlayerHealth.playerArmor < Damage)
				{
					
					int dmgLeft = (Damage -= PlayerHealth.playerArmor);
					PlayerHealth.playerHealth -= dmgLeft;
					PlayerHealth.playerArmor = 0;
					Damage = cDamage;
					
				}else
					PlayerHealth.playerArmor -= Damage;
			}else
			if(PlayerHealth.playerHealth != 0)
			{
				if(PlayerHealth.playerHealth <= Damage)
			{
				PlayerHealth.playerHealth = 0;
			}else
				PlayerHealth.playerHealth -= Damage;
			}

		}
			

		yield return new WaitForSeconds(1);

		print ("Attack Finish");
		isAttacking = false;
		Attacking = false;
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "plane")
		{
			//GetComponent<NavMeshAgent> ().enabled = true;
			StartCoroutine(WaitToStartNav(0.5f));
			print ("NAV MESH ACTIVATEDEEEE");
		}
	}
	
	IEnumerator WaitToStartNav(float time)
	{
		yield return new WaitForSeconds (time);
		GetComponent<NavMeshAgent> ().enabled = true;
	}




}
