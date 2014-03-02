using UnityEngine;
using System.Collections;

public class ShootBall : MonoBehaviour {

	public GameObject ball;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1)) {
			Instantiate(ball, transform.position, Quaternion.identity);
			ball.rigidbody.AddForce(Vector3.forward * 10);
		}
	}
}
