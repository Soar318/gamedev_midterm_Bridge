using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	public float jumpForce = 100f;
	public float jumpTimer = .5f;

	public bool canJump;
	public Rigidbody capPlayer;
	
	
	// Use this for initialization
	void Start ()
	{
		canJump = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
       	{
       		transform.Translate(0f, 0f, 0.3f);
       	}
		
		if (Input.GetKey(KeyCode.S))
       	{
       		transform.Translate(0f, 0f, -0.3f);
       	}

		if (Input.GetKey(KeyCode.D))
		{
			transform.Rotate(0f, 5f, 0f);
		}

		if (Input.GetKey(KeyCode.A))
       	{
       		transform.Rotate(0f, -5f, 0f);
       	}

	}

	void FixedUpdate()
	{
		if (canJump == true)
		{
			if (Input.GetKey(KeyCode.Space) && jumpTimer >= 0) 
			{
				capPlayer.AddForce(transform.up * jumpForce);
				jumpTimer -= Time.deltaTime;
			}
			
			else if (jumpTimer < 0) 
			{
				capPlayer.AddForce(transform.up * 0);
			}
		}
	}

	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag == "Ground")
		{
			canJump = true;
			jumpTimer = .5f;
		}
	}
}
