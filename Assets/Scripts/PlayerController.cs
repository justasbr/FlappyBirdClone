using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public Vector2 jumpForce = new Vector2(0, 450);
	public float ceiling;
	//public GameObject player;

	// Update is called once per frame
	void Update ()
	{
		if (transform.position.y < (-ceiling) || transform.position.y > (ceiling))  {
			Application.LoadLevel (Application.loadedLevel);	
		}
		// Jump
		if (Input.GetKeyDown("space"))
		{
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(jumpForce);
		}
		if (Input.GetKeyDown(KeyCode.R))
		{
			Application.LoadLevel (Application.loadedLevel);
		}
	}

	//void OnCollisionEnter2D(Collision2D other){
	//	Application.LoadLevel (Application.loadedLevel);
	//}
	void OnTriggerEnter2D(Collider2D other){
		Application.LoadLevel (Application.loadedLevel);
	}
}
