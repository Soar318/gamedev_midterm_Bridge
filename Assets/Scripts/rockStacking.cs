using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockStacking : MonoBehaviour
{

	public GameObject player;
	public GameObject rock;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (player.GetComponent<movement>().rockCounter == 1)
		{
			Instantiate(rock);
		}
	}
}
