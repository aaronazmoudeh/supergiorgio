using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoin : MonoBehaviour {

	public CurrentScore score_object;
	public GameObject score;
	public float current_score;
	public Text score_text;
	public GameObject coin;
	public float increment;

	void Start() {
		Debug.Log (score_object.getScore ());
		current_score = score_object.getScore ();
	}

	void OnTriggerEnter2D(Collider2D hit) {
		if (hit.tag == "Player") {
			current_score = score_object.getScore ();
			Destroy (coin);
			current_score += increment;
			score_object.setScore (current_score); 
			score_text.text = "Score: " + current_score;
		}
	}
}