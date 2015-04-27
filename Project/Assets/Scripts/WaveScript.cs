using UnityEngine;
using System.Collections;

public class WaveScript : MonoBehaviour 
{
	public float waveDuration;
	// Use this for initialization
	void Start () 
	{
		StartCoroutine("WaveTimer", waveDuration);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	IEnumerator WaveTimer(float t)
	{
		yield return new WaitForSeconds(t);
		//PlayerHealth.waveInt++;
		StartCoroutine("WaveTimer", t);
	}
}
