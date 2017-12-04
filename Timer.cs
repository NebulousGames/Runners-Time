using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text timerText;

	public static float timerCount = 0.0f;

	// Use this for initialization
	void Start () 
	{
		timerCount = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

		timerCount += 0.0175f;

		timerText.text = Mathf.Round(timerCount).ToString();

	}
}
