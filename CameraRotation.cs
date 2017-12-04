using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

	public float minAngle = 50.0f;
	public float maxAngle = -50.0f;

	void Start()
	{

	}

	void Update()
	{

		//Mouse rotation on the x axis

		transform.Rotate(-Mathf.Clamp(Input.GetAxisRaw("Mouse Y") * PlayerController.mouseSensitivity, minAngle, maxAngle), 0f, 0f);

	}

}
