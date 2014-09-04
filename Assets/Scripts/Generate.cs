using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {
	public GameObject pipe;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("CreateObstacle", 0.1f, 1.5f);
	}
	
	// Update is called once per frame
	void CreateObstacle() {
		Instantiate (pipe);
		//Debug.Log ("pipe invoke repeating");
	}
}
