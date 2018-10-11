using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockStacking : MonoBehaviour
{

	public GameObject player;
	public GameObject rock1;
	public GameObject rock2;
	public GameObject rock3;

	public bool rock1Loaded;
	public bool rock2Loaded;
	public bool rock3Loaded;

	
	// Use this for initialization
	void Start ()
	{
		rock1Loaded = false;
		rock2Loaded = false;
		rock3Loaded = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (player.GetComponent<movement>().rockCounter == 1)
		{
			if (rock1Loaded == false)
			{
				Instantiate(rock1, new Vector3(5.8f, 66.5f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				rock1Loaded = true;
			}
		}
		if (player.GetComponent<movement>().rockCounter == 2)
		{
			if (rock1Loaded == false && rock2Loaded == false)
			{
				Instantiate(rock1, new Vector3(5.8f, 67.5f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock2, new Vector3(5.8f, 68.5f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				rock1Loaded = true;
				rock2Loaded = true;
			}
		}
		if (player.GetComponent<movement>().rockCounter == 3)
		{
			if (rock1Loaded == false && rock2Loaded == false && rock3Loaded == false)
			{
				Instantiate(rock1, new Vector3(5.8f, 67.5f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock2, new Vector3(5.8f, 68.5f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock3, new Vector3(5.8f, 70.5f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				rock1Loaded = true;
				rock2Loaded = true;
				rock3Loaded = true;
			}

		}
	}
}
