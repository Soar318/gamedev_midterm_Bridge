﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startInstructions : MonoBehaviour
{

	public Text startInstruct;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		startInstruct.color = new Color(0f, 0f, 0f, 1f);
	}

	void OnTriggerExit(Collider other)
	{
		startInstruct.color = new Color(0f, 0f, 0f, 0f);
	}
}
