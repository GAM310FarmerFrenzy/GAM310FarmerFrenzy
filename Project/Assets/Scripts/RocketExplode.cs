using UnityEngine;
using System.Collections;

public class RocketExplode : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	public void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Enemy")
		{
			//Destroy(gameObject);
			other.SendMessage("GetDie");
		}
		
		Destroy(gameObject);
		
	}
}
