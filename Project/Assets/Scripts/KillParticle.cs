using UnityEngine;
using System.Collections;

public class KillParticle : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (KillTimer (5));
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	IEnumerator KillTimer(int t)
	{
		yield return new WaitForSeconds (t);
		DestroyObject (gameObject);
	}
}
