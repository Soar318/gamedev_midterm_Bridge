using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startInstructions : MonoBehaviour
{

	public Text startInstruct;
	public Text startInstruct2;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		startInstruct.color = new Color(1f, 1f, 1f, 1f);
		startInstruct2.color = new Color(1f, 1f, 1f, 1f);

	}

	void OnTriggerExit(Collider other)
	{
		startInstruct.color = new Color(0f, 0f, 0f, 0f);
		startInstruct2.color = new Color(0f, 0f, 0f, 0f);

	}
}
