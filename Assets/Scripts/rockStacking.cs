using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class rockStacking : MonoBehaviour
{

	public GameObject player;
	public GameObject rock1;
	public GameObject rock2;
	public GameObject rock3;
	public GameObject rock4;
	public GameObject rock5;
	public GameObject rock6;
	public GameObject rock7;
	public GameObject rock8;

	public Text score;

	public bool rock1Loaded;
	public bool rock2Loaded;
	public bool rock3Loaded;
	public bool rock4Loaded;
	public bool rock5Loaded;
	public bool rock6Loaded;
	public bool rock7Loaded;
	public bool rock8Loaded;

	public bool inTrigger;

	public AudioSource victorySound;
	public AudioSource bgMusic;
	
	// Use this for initialization
	void Start ()
	{
		rock1Loaded = false;
		rock2Loaded = false;
		rock3Loaded = false;
		rock4Loaded = false;
		rock5Loaded = false;
		rock6Loaded = false;
		rock7Loaded = false;
		rock8Loaded = false;
		score.color = new Color(0f, 0f, 0f, 0f);

		inTrigger = false;
		
		bgMusic.Play();

	}
	
	// Update is called once per frame
	void Update () {

		if (inTrigger == true)
		{

			if (Input.GetKeyDown(KeyCode.E))
			{
				SceneManager.LoadScene("Bridge");
			}

			bgMusic.Stop();
		}

	}

	void OnTriggerEnter(Collider other)
	{
		if (player.GetComponent<movement>().rockCounter > 0)
		{
			victorySound.Play();
		}
		
		inTrigger = true;
		player.GetComponent<movement>().enabled = false;
		score.color = new Color(1f, 1f, 1f, 1f);
		score.text = "Score: " + player.GetComponent<movement>().rockCounter + "\n Press E to Replay";		
		
		if (player.GetComponent<movement>().rockCounter == 1)
		{
			if (rock1Loaded == false)
			{
				Instantiate(rock1, new Vector3(5.8f, 20f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				rock1Loaded = true;
			}
		}
		if (player.GetComponent<movement>().rockCounter == 2)
		{
			if (rock1Loaded == false && rock2Loaded == false)
			{
				Instantiate(rock1, new Vector3(5.8f, 20f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock2, new Vector3(5.8f, 22f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				rock1Loaded = true;
				rock2Loaded = true;
			}
		}
		if (player.GetComponent<movement>().rockCounter == 3)
		{
			if (rock1Loaded == false && rock2Loaded == false && rock3Loaded == false)
			{
				Instantiate(rock1, new Vector3(5.8f, 20f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock2, new Vector3(5.8f, 22f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock3, new Vector3(5.8f, 24f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				rock1Loaded = true;
				rock2Loaded = true;
				rock3Loaded = true;
			}

		}
		if (player.GetComponent<movement>().rockCounter == 4)
		{
			if (rock1Loaded == false && rock2Loaded == false && rock3Loaded == false && rock4Loaded == false)
			{
				Instantiate(rock1, new Vector3(5.8f, 20f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock2, new Vector3(5.8f, 22f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock3, new Vector3(5.8f, 24f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock4, new Vector3(5.8f, 26f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				rock1Loaded = true;
				rock2Loaded = true;
				rock3Loaded = true;
				rock4Loaded = true;
			}

		}
		if (player.GetComponent<movement>().rockCounter == 5)
		{
			if (rock1Loaded == false && rock2Loaded == false && rock3Loaded == false && rock4Loaded == false && rock5Loaded == false)
			{
				Instantiate(rock1, new Vector3(5.8f, 20f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock2, new Vector3(5.8f, 22f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock3, new Vector3(5.8f, 24f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock4, new Vector3(5.8f, 26f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock5, new Vector3(5.8f, 28f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				rock1Loaded = true;
				rock2Loaded = true;
				rock3Loaded = true;
				rock4Loaded = true;
				rock5Loaded = true;
			}

		}
		if (player.GetComponent<movement>().rockCounter == 6)
		{
			if (rock1Loaded == false && rock2Loaded == false && rock3Loaded == false && rock4Loaded == false &&
			    rock5Loaded == false && rock6Loaded == false)
			{
				Instantiate(rock1, new Vector3(5.8f, 20f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock2, new Vector3(5.8f, 22f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock3, new Vector3(5.8f, 24f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock4, new Vector3(5.8f, 26f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock5, new Vector3(5.8f, 28f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock6, new Vector3(5.8f, 30f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				rock1Loaded = true;
				rock2Loaded = true;
				rock3Loaded = true;
				rock4Loaded = true;
				rock5Loaded = true;
				rock6Loaded = true;
			}

		}
		if (player.GetComponent<movement>().rockCounter == 7)
		{
			if (rock1Loaded == false && rock2Loaded == false && rock3Loaded == false && rock4Loaded == false &&
			    rock5Loaded == false && rock6Loaded == false && rock7Loaded == false)
			{
				Instantiate(rock1, new Vector3(5.8f, 20f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock2, new Vector3(5.8f, 22f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock3, new Vector3(5.8f, 24f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock4, new Vector3(5.8f, 26f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock5, new Vector3(5.8f, 28f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock6, new Vector3(5.8f, 30f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock7, new Vector3(5.8f, 32f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));

				rock1Loaded = true;
				rock2Loaded = true;
				rock3Loaded = true;
				rock4Loaded = true;
				rock5Loaded = true;
				rock6Loaded = true;
				rock7Loaded = true;
			}

		}
		if (player.GetComponent<movement>().rockCounter == 8)
		{
			if (rock1Loaded == false && rock2Loaded == false && rock3Loaded == false && rock4Loaded == false &&
			    rock5Loaded == false && rock6Loaded == false && rock7Loaded == false && rock8Loaded == false)
			{
				Instantiate(rock1, new Vector3(5.8f, 20f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock2, new Vector3(5.8f, 22f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock3, new Vector3(5.8f, 24f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock4, new Vector3(5.8f, 26f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock5, new Vector3(5.8f, 28f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock6, new Vector3(5.8f, 30f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock7, new Vector3(5.8f, 32f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));
				Instantiate(rock7, new Vector3(5.8f, 34f, 16.03982f), Quaternion.Euler(0f, 0f, 0f));

				rock1Loaded = true;
				rock2Loaded = true;
				rock3Loaded = true;
				rock4Loaded = true;
				rock5Loaded = true;
				rock6Loaded = true;
				rock7Loaded = true;
				rock8Loaded = true;
			}

		}
		
	}
}
