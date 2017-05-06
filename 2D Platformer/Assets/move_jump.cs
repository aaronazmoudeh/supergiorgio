using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_jump : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;
	public float num_jumps = 0;
	public bool isGrounded;
	public Transform ground_check;
	public float ground_check_radius;
	public LayerMask what_is_ground;

	// Use this for initialization
	void Start () {

	}

	void FixedUpdate() {
	
		isGrounded = Physics2D.OverlapCircle (ground_check.position, ground_check_radius, what_is_ground);
		if (isGrounded) {
			num_jumps = 0;
		}
	}
		
	// Update is called once per frame
	void Update () {

		GetComponent<Rigidbody2D>().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

		if (Input.GetKeyDown(KeyCode.Space) && num_jumps < 1) {
			GetComponent<Rigidbody2D>().velocity = new Vector2( moveSpeed, jumpHeight );
			num_jumps++;
		}
			
	}
}
