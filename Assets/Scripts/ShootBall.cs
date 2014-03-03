using UnityEngine;
using System.Collections;

public class ShootBall : MonoBehaviour {

	public GameObject ball;
	public Camera mainCamera;
	public float ballSpeed = 5000f;

	private Vector3 teleportPoint;
	private GameObject instance;
	private bool movingOn;

	// Use this for initialization
	void Start () {
		movingOn = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			instance = (GameObject) Instantiate(ball, transform.position + transform.forward, Quaternion.identity);
			instance.rigidbody.AddForce(mainCamera.transform.forward * ballSpeed);
			movingOn = true;
		}

		if (instance.GetComponent<TeleportCharacter>().firstColPoint != Vector3.zero && movingOn) {
			teleportPoint = instance.GetComponent<TeleportCharacter>().firstColPoint;
			transform.position = teleportPoint;
			movingOn = false;
		}
	}
}
