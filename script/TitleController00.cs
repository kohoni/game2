using UnityEngine;
using System.Collections;

public class TitleController00 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.X)) {
			//GetComponent<AudioSource> ().Play();
			Invoke ("Letusgo", 1.0f);
		}
	}

	void Letusgo(){
		Application.LoadLevel ("stage1");
		GetComponent<AudioSource> ().Play();
	}
}
