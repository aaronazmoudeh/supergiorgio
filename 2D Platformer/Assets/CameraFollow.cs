using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	private Transform player;

	// Use this for initialization
	void Start () {

		player = GameObject.Find ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 cam_pos = player.position;
		cam_pos.x += 100;
		cam_pos.z = transform.position.z;
		transform.position = cam_pos;
	}
}
