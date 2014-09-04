using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
	public int changeFactor;
	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = new Vector2(-4, 0);
		Vector2 oldPos = transform.position;
		Vector2 newPos = new Vector2(8f, oldPos.y - (changeFactor * Random.value));
		Debug.Log (oldPos.ToString());
		transform.position = newPos;
	}

}
