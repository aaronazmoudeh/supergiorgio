using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallOffMap : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D hit) {
		Debug.Log ("entered");
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
