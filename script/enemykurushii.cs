using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class enemykurushii : MonoBehaviour {


	//public GameObject waiting;
	//public GameObject gameover;
	//AudioSource warai;
	//AudioSource findyou;
	//AudioSource kurushii;


	// Use this for initialization
	void Start () {
		//waiting.SetActive (false);
		//gameover.SetActive (false);
		//warai = GetComponent<AudioSource>();
		//himei = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision c)
	{
		// レイヤー名を取得
		string layerName = LayerMask.LayerToName(c.gameObject.layer);

		// レイヤー名がBullet (Enemy)の時は弾を削除
		if( layerName == "enemy")
		{
			GetComponent<AudioSource>().Play ();
		}

	}
}
