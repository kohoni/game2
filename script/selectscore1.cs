using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class selectscore1 : MonoBehaviour {

	public TextMesh highscore;
	// Use this for initialization
	void Start () {
		highscore.text = "Hi : " + PlayerPrefs.GetFloat ("highlived") + "sec";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
