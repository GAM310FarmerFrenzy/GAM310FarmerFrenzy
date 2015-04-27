using UnityEngine;
using System.Collections;

public class RocketProjectile : MonoBehaviour 
{
	SphereCollider thisCol;// = gameObject.GetComponent<SphereCollider> ();
	public GameObject rocketExplodeParticle;
	public Vector3 thisPos;
	
	public GameObject hitExplosion;

	// Use this for initialization
	void Start () 
	{
		thisCol = gameObject.GetComponent<SphereCollider> ();
		thisCol.enabled = false;
		
		
		
		print ("THE ROCKET HAS SPAWNED");
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	public void OnTriggerEnter(Collider other)
	{
		/*
		if(other.tag == "Enemy")
		{
			//thisCol.enabled = true;
			print ("ROCKET DIED");
			Destroy(gameObject);
			other.SendMessage("GetDie");

		}
		*/
		
		thisCol.enabled = true;

		print ("THE COLLIDER IS EN " + thisCol.enabled);
		GameObject explodePart = Instantiate(Resources.Load("RocketExplode")) as GameObject;
		explodePart.transform.position = gameObject.transform.position;
		
		GameObject explode = Instantiate(hitExplosion) as GameObject;
		explode.transform.position = gameObject.transform.position;
		Destroy(gameObject);
		//print ("ROCKET DO A THING");
	}
}
