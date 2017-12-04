using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {

	public int lastLoadedLevel;
	public int lastLoadedLevelPlusOne = 2;

	private bool level2Active = false;
	private bool level3Active = false;
	private bool level4Active = false;
	private bool level5Active = false;
	private bool level6Active = false;
	private bool level7Active = false;
	private bool level8Active = false;

	public void LoadNextLevel()
	{

		Application.LoadLevel(Application.loadedLevel + 1 );


	}

	public void loadLevel2()
	{

			Application.LoadLevel ("Level_02");
		

	}

	public void loadLevel3()
	{


			Application.LoadLevel ("Level_03");
		

	}

	public void loadLevel4()
	{

			Application.LoadLevel ("Level_04");


	}

	public void loadLevel5()
	{

			Application.LoadLevel ("Level_05");


	}

	public void loadLevel6()
	{

			Application.LoadLevel ("Level_06");


	}

	public void loadLevel7()
	{

			Application.LoadLevel ("Level_07");


	}

	public void loadLevel8()
	{

			Application.LoadLevel ("Level_08");


	}

	public void PlayAgain()
	{

		Application.LoadLevel (lastLoadedLevel);

	}

	void Update()
	{

		if(SceneManager.GetActiveScene().name == "Level_01")
		{

		}

		if(SceneManager.GetActiveScene().name == "Level_02")
		{
			level2Active = true;
		}
	
		if(SceneManager.GetActiveScene().name == "Level_03")
		{
			level3Active = true;
		}

		if(SceneManager.GetActiveScene().name == "Level_04")
		{
			level4Active = true;
		}

		if(SceneManager.GetActiveScene().name == "Level_05")
		{
			level5Active = true;
		}

		if(SceneManager.GetActiveScene().name == "Level_06")
		{
			level6Active = true;
		}

		if(SceneManager.GetActiveScene().name == "Level_07")
		{
			level7Active = true;

		}

		if(SceneManager.GetActiveScene().name == "Level_08")
		{
			level8Active = true;
		}

	}
		
	public void Level2(){
		if(level2Active == true)
		{
			Application.LoadLevel("Level_02");
		}
	}
	public void Level3(){
		if(level3Active == true)
		{
		Application.LoadLevel("Level_03");
		}
	}
	public void Level4(){
		if(level4Active == true)
		{
		Application.LoadLevel("Level_04");
		}
	}
	public void Level5(){
		if(level5Active == true)
		{
		Application.LoadLevel("Level_05");
		}
	}
	public void Level6(){
		if(level6Active == true)
		{
		Application.LoadLevel("Level_06");
		}
	}
	public void Level7(){
		if(level7Active == true)
		{
		Application.LoadLevel("Level_07");
		}
	}
	public void Level8(){
		if(level8Active == true){
		Application.LoadLevel("Level_08");
		}
	}

	public void LoadMainMenu()
	{

		Application.LoadLevel("MainMenu");

	}

	public void ExitGame()
	{

		Application.Quit ();

	}
}
