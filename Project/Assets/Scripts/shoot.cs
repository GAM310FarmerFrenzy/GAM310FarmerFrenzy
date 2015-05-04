using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour 
{
	private float variance = 1.0f;
	private float distance = 10.0f;

	private Enemy enemyScript;

	public GameObject shotgunParticle;
	public GameObject akParticle;
	public GameObject handgunParticle;
	public GameObject rocketParticle;

	public GameObject rocketProjectile;

	public float bulletSpeed = 10.0f;

	public int rifleRange;
	public int shotgunRange;

	public static int shotgunDamage = 3;
	public static int rifleDamage = 3;

	public Transform handgunParticleLoc;
	public Transform shotgunParticleLoc;
	public Transform akParticleLoc;
	public Transform rocketParticleLoc;
	
	public AudioClip handGunSound;
	public AudioClip shotGunSound;
	public AudioClip rifleSound;
	public AudioClip rocketSound;
	
	private AudioSource gunAudio;

	public static bool hasHandgun = true;
	public static bool hasShotGun = false;
	public static bool hasAK = false;
	public static bool hasRocket = false;

	private bool isShooting = false;



	// Use this for initialization
	void Start () 
	{
		//print ("shotgun start " + shotgunDamage);
		gunAudio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(PauseMenu.Paused == false)
		{
			if(hasShotGun == true)
			{
				if(!isShooting)
				{
					ShootShotgun ();
				}

			}

			if(hasAK == true)
			{
				if(!isShooting)
				{
					ShootRifle ();
				}

			}

			if(hasRocket == true)
			{
				if(!isShooting)
				{
					ShootRocket ();
				}

			}

			if(hasHandgun == true)
			{
				if(!isShooting)
				{
					ShootHandgun ();
				}

			}


		}

	}

	void ShootShotgun()
	{
		RaycastHit hit;
		if(WeaponManager.Weapon == 2)
		{

			if(Input.GetMouseButtonDown(0))
			{
				if(PlayerHealth.shotGunAmmo > 0)
				{
					PlayerHealth.shotGunAmmo --;
					isShooting = true;
					StartCoroutine("ShootDelay", 0.717f);
					gunAudio.PlayOneShot(shotGunSound, 0.7f);
					
					for(int i = 0; i < 5; i++)
					{
						Vector3 offset = transform.up * Random.Range(0.0f, variance);
						offset = Quaternion.AngleAxis(Random.Range(0.0f, 360.0f), transform.position) * offset;
						Vector3 HitSum = Camera.main.transform.forward * distance + offset;

						
						if(Physics.Raycast(transform.position, HitSum, out hit))
						{
							if(hit.distance <= shotgunRange)
							{
								if(hit.transform.tag == "Enemy")
								{
									hit.collider.gameObject.SendMessage("DamageMe",shotgunDamage);
									//print("hit the enemy");
								}
							}
						}

						Debug.DrawRay (transform.position, HitSum, Color.blue);
						

					}


					
					GameObject particle = Instantiate (shotgunParticle) as GameObject;
					particle.transform.position = shotgunParticleLoc.transform.position;
					particle.transform.rotation = Camera.main.transform.rotation;
				}

			}
			//print ("do a thing");
		}
	}

	void ShootRifle()
	{
		RaycastHit hit;
		if(WeaponManager.Weapon == 3)
		{
			if(Input.GetMouseButtonDown(0))
			{
				if(PlayerHealth.rifleAmmo > 0)
				{
					PlayerHealth.rifleAmmo --;
					isShooting = true;
					StartCoroutine("ShootDelay", 0.1f);
					gunAudio.PlayOneShot(rifleSound, 0.7f);
					
					Vector3 rShoot = Camera.main.transform.forward;
					
					if(Physics.Raycast(transform.position, rShoot, out hit))
					{
						if(hit.distance <= rifleRange)
						{
							if(hit.transform.tag == "Enemy")
							{
								hit.collider.gameObject.SendMessage("DamageMe", rifleDamage);
								
							}
						}
						//Debug.DrawRay (transform.position, rShoot, Color.blue);
						//print ("hit something");
					}

					GameObject particle = Instantiate (akParticle) as GameObject;
					particle.transform.position = akParticleLoc.transform.position;// + Camera.main.transform.forward;
					particle.transform.rotation = Camera.main.transform.rotation;






					Debug.DrawRay (transform.position, rShoot * rifleRange, Color.blue);
				}

			}

		}

	}

	void ShootHandgun()
	{
		RaycastHit hit;
		if(WeaponManager.Weapon == 1)
		{
			if(Input.GetMouseButtonDown(0))
			{
				if(PlayerHealth.rifleAmmo > 0)
				{
					PlayerHealth.rifleAmmo --;
					isShooting = true;
					StartCoroutine("ShootDelay", 0.317);
					
					gunAudio.PlayOneShot(handGunSound, 0.7f);
					
					Vector3 rShoot = Camera.main.transform.forward;
					
					if(Physics.Raycast(transform.position, rShoot, out hit))
					{
						if(hit.distance <= rifleRange)
						{
							if(hit.transform.tag == "Enemy")
							{
								hit.collider.gameObject.SendMessage("DamageMe", rifleDamage);
								
							}
						}
						//Debug.DrawRay (transform.position, rShoot, Color.blue);
						//print ("hit something");
					}
					
					GameObject particle = Instantiate (handgunParticle) as GameObject;
					particle.transform.position = handgunParticleLoc.transform.position;// + Camera.main.transform.forward;
					particle.transform.rotation = Camera.main.transform.rotation;
					
					
					
					
					
					
					Debug.DrawRay (transform.position, rShoot * rifleRange, Color.blue);
				}
				
			}
			
		}
		
	}

	void ShootRocket()
	{
		RaycastHit hit;
		if(WeaponManager.Weapon == 4)
		{
			if(Input.GetMouseButtonDown(0))
			{
				if(PlayerHealth.rocketAmmo > 0)
				{
					PlayerHealth.rocketAmmo --;
					isShooting = true;
					StartCoroutine("ShootDelay", 1.017f);
					
					gunAudio.PlayOneShot(rocketSound, 0.7f);

					Vector3 rShoot = Camera.main.transform.forward;
					
					if(Physics.Raycast(transform.position, rShoot, out hit))
					{
						if(hit.distance <= rifleRange)
						{
							if(hit.transform.tag == "Enemy")
							{
								hit.collider.gameObject.SendMessage("DamageMe", rifleDamage);
								
							}
						}
						//Debug.DrawRay (transform.position, rShoot, Color.blue);
						//print ("hit something");
					}
					
					GameObject particle = Instantiate (rocketParticle) as GameObject;
					particle.transform.position = rocketParticleLoc.transform.position;// + Camera.main.transform.forward;
					particle.transform.rotation = Camera.main.transform.rotation;

					GameObject projectile = Instantiate (rocketProjectile) as GameObject;
					projectile.transform.position = rocketParticleLoc.transform.position;// + Camera.main.transform.forward;
					projectile.transform.rotation = Camera.main.transform.rotation;
					Rigidbody rocketRigid = projectile.GetComponent<Rigidbody>();
					rocketRigid.velocity = Camera.main.transform.forward * 5000 * Time.deltaTime;
					
					
					
					
					
					
					Debug.DrawRay (transform.position, rShoot * rifleRange, Color.blue);
				}
				
			}
			
		}
		
	}


	private void OnTriggerEnter(Collider other)
	{
	
			if(other.tag=="ShotGunPickup")
			{
				hasShotGun = true;
				WeaponManager.Weapon = 2;
			}
			
			if(other.tag=="AK47Pickup")
			{
				hasAK = true;
				WeaponManager.Weapon = 3;
			}
			
			if(other.tag=="RocketlauncherPickup")
			{
				hasRocket = true;
				WeaponManager.Weapon = 4;
			}

	}		

	IEnumerator ShootDelay(float delay)
	{
		yield return new WaitForSeconds(delay);
		isShooting = false;
	}



}
