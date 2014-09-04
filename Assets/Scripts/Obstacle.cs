using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
	public Vector2 velocity = new Vector2(-4, 0);
	public int changeFactor;
	public float lifeTime;

	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = velocity;
		Vector2 oldPos = transform.position;
		Vector2 newPos = new Vector2(oldPos.x, oldPos.y - (changeFactor * Random.value));
		transform.position = newPos;
		//Debug.Log (player.transform.position.x);
	}
	void Awake() {
		Destroy (gameObject, lifeTime);
	}
	//void Update() {
	//}
}
