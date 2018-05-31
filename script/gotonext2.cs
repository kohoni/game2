using UnityEngine;
using System.Collections;

public class gotonext2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision c)
	{
		// レイヤー名を取得
		string layerName = LayerMask.LayerToName(c.gameObject.layer);

		// レイヤー名がBullet (Enemy)の時は弾を削除
		if( layerName == "player")
		{
			//goal.SetActive (true);
			//audioSource.clip = nigasanai;
			//audioSource.loop = false;
			//audioSource.spatialBlend = 0;
			//audioSource.Play ();

			Debug.Log ("goal!!");
			//IsPlaying = false;
			Invoke ("nextstage", 3.0f);
			//Destroy (gameObject);
		}

	}

	void nextstage(){
		Application.LoadLevel ("stage2");
	}
}
