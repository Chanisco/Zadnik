﻿using UnityEngine;
using System.Collections;

public class ScreenRotation : MonoBehaviour {

	private Quaternion screenRotation;
	public float speed = 5;
	// Use this for initialization
	void Start () {
		screenRotation = transform.rotation;
		//Screen.orientation = ScreenOrientation.LandscapeLeft;
	}
	
	// Update is called once per frame
	void Update () {
		float newSpeed = speed * Time.deltaTime;

		screenRotation.x = Input.acceleration.x * newSpeed;
		screenRotation.y = Input.acceleration.y * newSpeed;


	
		//Debug.Log("ScreenY = " + Mathf.Round(screenRotation.y));	//Y = 10 - 16 || -10 -16
		//Debug.Log("ScreenX = " + screenRotation.x);
		//Debug.Log("ScreenZ = " + screenRotation.z);

		transform.rotation = screenRotation;

	}
}
