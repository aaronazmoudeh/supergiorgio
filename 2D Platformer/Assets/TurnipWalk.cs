using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnipWalk : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Rigidbody2D>().velocity = new Vector2 (moveSpeed, 0);
	}
}
