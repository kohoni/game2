using UnityEngine;
using System.Collections;

public class Move6 : MonoBehaviour {
	//public bool isPlaying = true;
	public float speed = 0;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
			if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(-1*Vector3.up * speed * Time.deltaTime);
			}
			if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(Vector3.up * speed * Time.deltaTime);
			}
			if (Input.GetKey (KeyCode.W)) {
			transform.Rotate(Vector3.left * speed * Time.deltaTime);
			}
			if (Input.GetKey (KeyCode.S)) {
			transform.Rotate(-1*Vector3.left * speed * Time.deltaTime);
			}
		}



}
