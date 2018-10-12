using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed_mod;
	public float jump_mod;
	public float max_speed;

	private Rigidbody2D body;
	private ContactPoint2D[] body_contacts = new ContactPoint2D[4];
	private bool on_ground;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D>();
		on_ground = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		//get the input from both axes
		float axis_x = Input.GetAxis("Horizontal");
		float axis_y = Input.GetAxis("Vertical");

		Vector2 acc = new Vector2(axis_x, 0.0f);
		int contact_count = body.GetContacts(body_contacts);
		for (int i = 0; i < contact_count; i++)
		{
			if (body_contacts[i].collider.gameObject == null)
				continue;
			if(body_contacts[i].collider.gameObject.tag == "LevelGeometry")
			{
				on_ground = true;
			}
		}

		if (on_ground && axis_y != 0.0f)
		{
			acc.y = 1.0f * jump_mod;
			on_ground = false;
		}

		if (body.velocity.x < max_speed || body.velocity.x > -max_speed)
			body.AddForce(acc * speed_mod);
		else if (body.velocity.x > max_speed || body.velocity.x < -max_speed)
			body.velocity = new Vector2(max_speed, 0.0f);
	}
}
