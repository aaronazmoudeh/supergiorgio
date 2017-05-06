using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour {

	public string level_to_load;
	public Text text;
	public CurrentScore score;

	void OnTriggerEnter2D(Collider2D hit) {
		if (hit.tag == "Player") {
			if (level_to_load.Equals("done")) {
				
			} else {
				StartCoroutine (holdon ());
			}
		}
	}

	IEnumerator	holdon () {
		text.text = "Next level! Your score on this level was " + score.getScore () + " points!";
		yield return new WaitForSeconds(0);
		text.text = "";
		Application.LoadLevel (level_to_load);
		StopCoroutine (holdon ());
	}

	IEnumerator	over () {
		text.text = "You win! Congratulations!";
		yield return new WaitForSeconds(0);
		text.text = "";
		Application.Quit ();
		StopCoroutine (holdon ());
	}
}
