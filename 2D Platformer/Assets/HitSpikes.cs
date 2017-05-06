using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitSpikes : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D hit) {
		if (hit.tag == "Player") {
			Debug.Log ("entered");
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}
}