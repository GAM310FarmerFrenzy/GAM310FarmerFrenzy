using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour 
{
	public static int playerHealth = 10;

	public Canvas deathCanvas;

	public static int shotGunAmmo = 10;
	public static int rifleAmmo = 10;
	public static int rocketAmmo = 5;

	public static int playerArmor = 0;

	public static bool invuln = false;

	//public static float invTime;

	public static int waveInt = 0;

	public static int scoreInt;

	public GameObject getHitParticle;
	public Transform hitParticleLoc;

	// Use this for initialization
	void Start () 
	{
		//deathCanvas = GetComponent<Canvas> ();
		deathCanvas.enabled = false;

	}

	public void HurtParticle()
	{
		GameObject hitParticle = Instantiate(getHitParticle) as GameObject;
		hitParticle.transform.position = hitParticleLoc.transform.position;

		hitParticle.transform.parent = hitParticleLoc;

		print("SEND MESSAGE WORKED OUCH");
	}
	public void startInvTimer(float t)
	{
		//StartCoroutine (InvTimer (invTime));
		print ("INVINCIBLE ON " + t);
		invuln = true;
		Invoke("InvTimer", t);
	}
	
	private void InvTimer()
	{
		print ("INVINCIBLE OFF");
		invuln = false;
	}

	/*IEnumerator InvTimer(float t)
	{
		print ("INVINCIBLE ON " + invTime);
		invuln = true;
		yield return new WaitForSeconds(t);
		print ("INVINCIBLE OFF");
		invuln = false;
	}*/
	
	// Update is called once per frame
	void Update () 
	{
		if(playerHealth <= 0)
		{
			PauseMenu.Paused = true;
			Time.timeScale = 0;
			deathCanvas.enabled = true;
		}
	}
}
