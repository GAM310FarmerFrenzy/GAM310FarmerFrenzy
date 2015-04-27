using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void LoadOne()
	{
		Application.LoadLevel (1);
	}

	public void LoadMainMenu()
	{
		Application.LoadLevel (0);
	}

	public void LoadInstructions()
	{
		Application.LoadLevel (2);
	}
	public void LoadCredits()
	{
		Application.LoadLevel (3);
	}
	public void QuitApplication()
	{
		Application.Quit();
	}
}
