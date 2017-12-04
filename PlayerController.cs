using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public Rigidbody playerRigidbody;

	public static int whatLevelToLoad = 2;

	public float playerMomentum = 1250.0f;
	public float jumpHeight = 7.0f;
	public float wallRunHeight = 14.0f;
	public static float mouseSensitivity = 5.0f;

	public Animator playerAnimations;

	private bool animationIsRunning = false;
	private bool isFalling;

	void Start()
	{

		playerAnimations.Play ("Idle");

		isFalling = false;

	}

	void FixedUpdate()
	{

		//Basic character controls using WASD
		BasicCntrls ();

		//All flips
		FrontFlip();
		Webster ();
		Backflip ();
		Gainer ();

		if(Timer.timerCount >= 25f)
		{

			playerMomentum = 1000;

		}

		if(Timer.timerCount >= 30f)
		{

			playerMomentum = 750;

		}


		if(Timer.timerCount >= 40f)
		{

			playerMomentum = 650;

		}

		if(Timer.timerCount >= 50f)
		{

			playerMomentum = 550;

		}

		if(Timer.timerCount >= 750f)
		{

			playerMomentum = 350;

		}

		//Jump Control
		JumpCntrl ();

		//Says that the player is falling if it is not colliding with anythin
		isFalling = true;

		//Rotates the player on it's Y-axis using mouse input
		transform.Rotate(Vector3.up, Input.GetAxisRaw("Mouse X") * mouseSensitivity);

	}

	void OnCollisionEnter(Collision col)
	{

		if(col.gameObject.tag == "Void")
		{

			Timer.timerCount = 0.0f;


			SceneController.mouseVisible = true;

			Application.LoadLevel ("DeathScreen");


		}

		//Wallrun
		/*
		if(col.gameObject.tag == "Wall"  && Input.GetKeyDown(KeyCode.R))
		{

			playerRigidbody.AddForce (0f, wallRunHeight, 0f, ForceMode.Impulse);

			Debug.Log ("Wallrun");

		}
		*/

	}

	void OnTriggerEnter(Collider trig)
	{

		if (trig.gameObject.tag == "Win") 
		{

			SceneController.mouseVisible = true;

			whatLevelToLoad = 2;

			Application.LoadLevel ("WinScreen");

		}

		if (trig.gameObject.tag == "Win2") 
		{

			SceneController.mouseVisible = true;

			whatLevelToLoad = 3;

			Application.LoadLevel ("WinScreen 1");

		}

		if (trig.gameObject.tag == "Win3") 
		{

			SceneController.mouseVisible = true;

			whatLevelToLoad = 3;

			Application.LoadLevel ("WinScreen 2");

		}

		if (trig.gameObject.tag == "Win4") 
		{

			SceneController.mouseVisible = true;

			whatLevelToLoad = 4;

			Application.LoadLevel ("WinScreen 3");

		}

		if (trig.gameObject.tag == "Win5") 
		{

			SceneController.mouseVisible = true;

			whatLevelToLoad = 5;

			Application.LoadLevel ("WinScreen 4");

		}

		if (trig.gameObject.tag == "Win6") 
		{

			SceneController.mouseVisible = true;

			whatLevelToLoad = 6;

			Application.LoadLevel ("WinScreen 5");

		}

		if (trig.gameObject.tag == "Win7") 
		{

			SceneController.mouseVisible = true;

			whatLevelToLoad = 7;

			Application.LoadLevel ("WinScreen 6");

		}

		if (trig.gameObject.tag == "Win8") 
		{

			SceneController.mouseVisible = true;

			whatLevelToLoad = 8;

			Application.LoadLevel ("WinScreen 7");

		}

	}

	void JumpCntrl()
	{

		if (Input.GetKeyDown (KeyCode.Space) && isFalling == false)
		{

			playerRigidbody.AddForce (0f, jumpHeight, 0f, ForceMode.Impulse);

		}

	}
		

	//This method runs the front flip animation
	void FrontFlip()
	{

		//Gets key input and checks to make sure that an animation is not running
		if (Input.GetKeyDown (KeyCode.LeftShift) && animationIsRunning == false && isFalling == false) 
		{

			animationIsRunning = true;

			playerRigidbody.AddForce (0f, jumpHeight / 2, 0f, ForceMode.Impulse);

			playerAnimations.Play ("FrontFlip");

			animationIsRunning = false;

			Timer.timerCount -= 0.6f;

		} 
			

	}

	//This method runs the webster animation
	void Webster()
	{

		//Gets key input and checks to make sure that an animation is not running
		if (Input.GetKeyDown (KeyCode.LeftShift) && Input.GetKey (KeyCode.W) && animationIsRunning == false && isFalling == false) 
		{

			animationIsRunning = true;
	
			playerRigidbody.AddForce (0f, jumpHeight / 5, 0f, ForceMode.Impulse);

			playerAnimations.Play ("Webster");

			animationIsRunning = false;

			Timer.timerCount -= 1f;


		}


	}

	//This method runs the backflip animation
	void Backflip()
	{

		//Gets key input and checks to make sure that an animation is not running
		if (Input.GetKeyDown (KeyCode.Q) && animationIsRunning == false && isFalling == false) 
		{

			//Gets key input and checks to make sure that an animation is not running

			animationIsRunning = true;

			playerRigidbody.AddForce (0f, jumpHeight / 2, 0f, ForceMode.Impulse);

			playerAnimations.Play ("Backflip");

			animationIsRunning = false;

			Timer.timerCount -= 0.6f;


		}

	}

	//This method runs the Gainer animation
	void Gainer()
	{

		//Gets key input and checks to make sure that an animation is not running
		if (Input.GetKeyDown (KeyCode.Q) && Input.GetKey (KeyCode.W) && animationIsRunning == false && isFalling == false) 
		{

			animationIsRunning = true;

			playerRigidbody.AddForce (0f, jumpHeight / 5, 0f, ForceMode.Impulse);

			playerAnimations.Play ("Gainer");

			animationIsRunning = false;

			Timer.timerCount -= 1.5f;


		}


	}

	void OnCollisionStay()
	{

		//This means that the player isn't falling when it collides with something
		isFalling = false;

	}

	//Basiv controls using WASD
	void BasicCntrls()
	{

		//Moves the player forward on a local axis when W is pressed
		if(Input.GetKey(KeyCode.W))
		{

			playerRigidbody.AddRelativeForce (0f, 0f, playerMomentum * Time.deltaTime);

		}

		//Moves the player backwars on a local axis when S is pressed
		if(Input.GetKey(KeyCode.S))
		{

			playerRigidbody.AddRelativeForce (0f, 0f, -playerMomentum * Time.deltaTime);

		}

		//Moves the player left on a local axis when A is pressed
		if(Input.GetKey(KeyCode.A))
		{

			playerRigidbody.AddRelativeForce (-playerMomentum * Time.deltaTime, 0f, 0f);

		}

		//Moves the player right on a local axis when D is pressed
		if(Input.GetKey(KeyCode.D))
		{

			playerRigidbody.AddRelativeForce (playerMomentum * Time.deltaTime, 0f, 0f);

		}

	}

}
