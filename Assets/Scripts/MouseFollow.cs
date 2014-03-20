using UnityEngine;
using System.Collections;

public class MouseFollow : MonoBehaviour {
	
	public float smooth = 50.0F;
	public float tiltAngle = 30.0F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Select a specific word like 'transform' and do (CMD + ') to open up the docs
		//transform.position = new Vector3(2, 0, 0);
		//transform.Translate(0.2f, 0, 0);
		//transform.position = new Vector3(Input.mousePosition.x, 0, 0);
		//Debug.Log (Input.mousePosition);
		//Debug.Log ((Input.mousePosition.x - Screen.width / 2) / (Screen.width / 2));
		float half_width = Screen.width / 4;
		float half_height = Screen.height / 3;
		float new_x_position = 2 * (Input.mousePosition.x - half_width) / half_width;
		float new_z_position = (Input.mousePosition.y - half_height) / half_height;
		transform.position = new Vector3(new_x_position, transform.position.y, new_z_position);

		// Rotate smoothly towards a target
		float tiltAroundZ = Input.GetAxis("Mouse X") * tiltAngle * 2;
		float tiltAroundX = Input.GetAxis("Mouse Y") * tiltAngle * -2;
		Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
		transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
	}

}
