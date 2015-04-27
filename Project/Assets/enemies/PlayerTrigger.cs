using UnityEngine;
using System.Collections;

public class PlayerTrigger : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	private void OnTriggerEnter(Collider other)
	{
		print (other);
		other.GetComponent<Enemy>().Range = true;
		print ("Hit");
	}
	private void OnTriggerExit(Collider other)
	{
		other.GetComponent<Enemy>().Range = false;
	}
}
