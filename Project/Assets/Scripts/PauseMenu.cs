using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour 
{
	public static bool Paused = false;

	Canvas pauseCanvas;



	// Use this for initialization
	void Start () 
	{
		pauseCanvas = GetComponent<Canvas> ();
		pauseCanvas.enabled = false;

		//Cursor.lockState = CursorLockMode.Locked;
		//Cursor.visible = false;



	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonDown("Pause"))
		{
			Pause();
			//print ("do a thing");
		}

		if(Paused)
		{
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}else
		{
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;
		}
			




	}

	public void Pause()
	{
		if(Paused == false)
		{
			//Cursor.lockState = CursorLockMode.Locked;
			//Cursor.visible = true;
			pauseCanvas.enabled = true;
			Paused = true;
			Time.timeScale = 0;
			print (Paused);

		}else 
		{
			//Cursor.lockState = CursorLockMode.None;
			//Cursor.visible = false;
			Paused = false;
			Time.timeScale = 1;
			pauseCanvas.enabled = false;
			print (Paused);
		}
	}
}
