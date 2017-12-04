using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	public static bool mouseVisible = false;

	// Use this for initialization
	void Update () 
	{

		Cursor.visible = mouseVisible;

	}


	public static void PlayAgain()
	{

		SceneManager.LoadScene (SceneManager.GetActiveScene().name);

	}
		

}
