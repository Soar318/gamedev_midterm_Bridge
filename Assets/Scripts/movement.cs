using System.Collections;
using System.Collections.Generic;
using System.Xml.Xsl;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
	public float jumpForce = 2f; //how much force is applied, I have it super high cuz high
                               //grav feels better
	
	public float jumpTimer = .3f; //counter for how long the player can jump for, .5f is sorta
                               //a glide at this point

	public int rockCounter; //nothing u need to worry bout

	public bool canJump; //bool for whether or not player can jump at all, is true if it hits
                      //the ground, is false if player is in the air
	
	public Rigidbody capPlayer; //rigidbody of the player object
	
	
	// Use this for initialization
	void Start ()
	{
		canJump = false; //my player spawns in the air, so at the start player cannot jump until
                   //they hit the ground
		
		//setting some values dont worry bout it
		jumpTimer = .3f; 
		jumpForce = 2f;
		rockCounter = 3;
	}
	
	// Update is called once per frame
	void Update () {
		
		//movement code for forward, backward, and left and right rotation
		if (Input.GetKey(KeyCode.W))
       	{
       		transform.Translate(0f, 0f, 0.2f);
       	}
		
		if (Input.GetKey(KeyCode.S))
       	{
       		transform.Translate(0f, 0f, -0.2f);
       	}

		if (Input.GetKey(KeyCode.D))
		{
			transform.Rotate(0f, 3f, 0f);
		}

		if (Input.GetKey(KeyCode.A))
       	{
       		transform.Rotate(0f, -3f, 0f);
       	}

	}

	void FixedUpdate()
	{
		if (canJump == true) //if player can jump...
		{
			if (Input.GetKey(KeyCode.Space) && jumpTimer >= 0) //if player presses space AND the
                                                      //jump timer is greater than or less than zero
			{
				
				capPlayer.AddForce(transform.up * jumpForce, ForceMode.Impulse); // apply force upward multiplied
                                                  // by the amount of force
				
				jumpTimer -= Time.deltaTime; //amount of time player can jump for goes down
			}
			
			else if (jumpTimer < 0) //once the timer hits less than zero...
			{
				capPlayer.AddForce(transform.up * 0); //force is multiplied by zero 
			}
		}
	}

	void OnCollisionEnter (Collision collision)
	{
		//TAGS TAGS TAGS 
		if (collision.gameObject.tag == "Ground") //tag ground shit
		{
			canJump = true; //if player is on the ground then they can jump
			
			jumpTimer = .3f; //timer resets
		}

		if (collision.gameObject.tag == "Water")
		{
			SceneManager.LoadScene("Bridge");
		}

		if (collision.gameObject.tag == "Rock")
		{
			rockCounter += 1;
		}
	}
}
