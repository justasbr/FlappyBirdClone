using UnityEngine;
using System.Collections;

public class scoreCounter : MonoBehaviour {
	private int score = 0;
	private static int record = 0;
	public GUIText scoreText;
	public GUIText recordText;
	void Start(){
		scoreText.text = score.ToString ();
		recordText.text = "Record: " + record.ToString ();
	}
	void OnTriggerEnter2D(Collider2D other) {
		score++;
		UpdateScore ();
	}

	void UpdateScore(){
		scoreText.text = score.ToString ();
		if (score == 3) {
			scoreText.text = "OH BABY";
			audio.Play ();		
		}
		if (score > record) {
			record = score;
			recordText.text = "Record: " + record.ToString ();
		}
	}
}
