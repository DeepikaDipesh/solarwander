﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth_CenterOfGravity : MonoBehaviour {

	float rotationSpeed = 6.0f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(0,rotationSpeed*Time.deltaTime,0);
	}
}
