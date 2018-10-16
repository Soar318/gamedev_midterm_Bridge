using System.Collections;
using System.Collections.Generic;
using System.Xml.Xsl;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
	public float jumpForce = 2f; 
	public float jumpTimer = .3f;
	public float fretTimer = 1.5f;

	public int rockCounter;
	public int fretCounter;

	public bool canJump;
	public bool fretTextOn;
	
	public Rigidbody capPlayer;

	public Text fretFret; 
	
	
	// Use this for initialization
	void Start ()
	{
		canJump = false;
		jumpTimer = .3f; 
		jumpForce = 2f;
		rockCounter = 0;

		fretTimer = 1f;
		fretCounter = 0;
		fretFret.color = new Color(0f, 0f, 0f, 0f);
		fretTextOn = false;
	}
	
	// Update is called once per frame
	void Update () {
		
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

		
		if (Input.GetKeyDown(KeyCode.F))
		{
			fretTextOn = true;
			fretCounter = (Random.Range(1, 25));
		}

		if (fretTextOn == true)
		{
			fretFret.color = new Color(0f, 0f, 0f, 1f);
			fretTimer -= Time.deltaTime;
		}

		if (fretTimer < 0)
		{
			fretTextOn = false;
			fretTimer = 1f;
			fretCounter = 0;
		}

		if (fretTextOn == false)
		{
			fretFret.color = new Color(0f, 0f, 0f, 0f);
		}

		if (fretCounter == 1)
		{
			fretFret.text = "Oh god why am I doing this???";
		}
		if (fretCounter == 2)
		{
			fretFret.text = "This is so stupid I'm definitely going to fall.";
		}
		if (fretCounter == 3)
		{
			fretFret.text = "This isn't worth it it's just a bunch of rocks.";
		}
		if (fretCounter == 4)
		{
			fretFret.text = "Why am I like this??";
		}
		if (fretCounter == 5)
		{
			fretFret.text = "Guess I'll perish.";
		}
		if (fretCounter == 6)
		{
			fretFret.text = "I will face God and walk backwards into Hell";
		}
		if (fretCounter == 7)
		{
			fretFret.text = "If I die here it won't even pay my tuition.";
		}
		if (fretCounter == 8)
		{
			fretFret.text = "Why am I doing this again???";
		}
		if (fretCounter == 9)
		{
			fretFret.text = "Wow this is moronic.";
		}
		if (fretCounter == 10)
		{
			fretFret.text = "HHHHHHHHHHHHHHH";
		}
		if (fretCounter == 11)
		{
			fretFret.text = "Does this even count as an 'additional mechanic'???";
		}
		if (fretCounter == 12)
		{
			fretFret.text = "Shit I forgot to update my devlog";
		}
		if (fretCounter == 13)
		{
			fretFret.text = "What if I break my leg??";
		}
		if (fretCounter == 14)
		{
			fretFret.text = "Do I really want to die like this?";
		}
		if (fretCounter == 15)
		{
			fretFret.text = "All this for some rocks.";
		}
		if (fretCounter == 16)
		{
			fretFret.text = "My life peaks here I guess.";
		}
		if (fretCounter == 17)
		{
			fretFret.text = "My balance is not up to this.";
		}
		if (fretCounter == 18)
		{
			fretFret.text = "Definitely going to slip and fall.";
		}
		if (fretCounter == 19)
		{
			fretFret.text = "Oh god I think I have vertigo.";
		}
		if (fretCounter == 20)
		{
			fretFret.text = "Tell my dogs I love them.";
		}
		if (fretCounter == 21)
		{
			fretFret.text = "According to all known laws of aviation, there is no way a bee should be able to fly. " +
			                "Its wings are too small to get its fat little body off the ground. The bee,of course, " +
			                "flies anyway because bees don't care what humans think is impossible. Yellow, black. " +
			                "Yellow, black. Yellow, black. Yellow, black. Ooh, black and yellow! Let's shake it up a " +
			                "little. Barry! Breakfast is ready! Coming! Hang on a second. Hello? - Barry? - Adam? - Can " +
			                "you believe this is happening? - I can't. I'll pick you up.";
		}
		if (fretCounter == 22)
		{
			fretFret.text = "Ohhhh boy top ten dumbest things I've done, easy.";
		}
		if (fretCounter == 23)
		{
			fretFret.text = "There was actually a Mavic Air drone on me IRL.";
		}
		if (fretCounter == 24)
		{
			fretFret.text = "What if I fall? What if I die? WHAT IF I FALL AND DIE.";
		}
		if (fretCounter == 25)
		{
			fretFret.text = "Random.Range doesn't like max ints for some reason, you'll never see this.";
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
