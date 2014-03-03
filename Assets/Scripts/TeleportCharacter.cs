using UnityEngine;
using System.Collections;

public class TeleportCharacter : MonoBehaviour {

	public bool teleportable;
	public Vector3 firstColPoint = Vector3.zero;

	// Use this for initialization
	void Start () {
		teleportable = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col) {
		if (teleportable) {
			firstColPoint = col.contacts[0].point + new Vector3 (0f, 5f, 0f);
		}

		teleportable = false;
	}
}
