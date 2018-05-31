using UnityEngine;
using System.Collections;

public class Move5 : MonoBehaviour {
    public float speed;
	public GameObject goal;
	//Rigidbody rb;
	//public float teraspeed;
	public bool IsPlaying = true;
	//public bool isPlaying = true;

	// Use this for initialization
	void Start () {
  		//rb = gameObject.GetComponent<Rigidbody>();
		goal.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		if(IsPlaying == true){
			if (Input.GetKey (KeyCode.RightArrow)) {
				transform.position += new Vector3 (1*speed,0.0f,0.0f);
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
			    transform.position += new Vector3 (-1*speed,0.0f,0.0f);
			}
		    if (Input.GetKey (KeyCode.UpArrow)) {
				transform.position += new Vector3 (0.0f,0.0f,1*speed);
			}
		    if (Input.GetKey (KeyCode.DownArrow)) {
			    transform.position += new Vector3 (0.0f,0.0f,-1*speed);
		    }
			//automatic movement
			//teraspeed = teraspeed + (speed * Time.deltaTime);
			//transform.position += new Vector3 (0.0f, 0.0f, teraspeed);
		}
	}

	void OnCollisionEnter(Collision c)
	{
		// レイヤー名を取得
		string layerName = LayerMask.LayerToName(c.gameObject.layer);

		// レイヤー名がBullet (Enemy)の時は弾を削除
		if( layerName == "goal")
		{
			goal.SetActive (true);
			//audioSource.clip = nigasanai;
			//audioSource.loop = false;
			//audioSource.spatialBlend = 0;
			//audioSource.Play ();
			Debug.Log ("hit");
			IsPlaying = false;
			//Invoke ("nextstage", 3.0f);
			//Destroy (gameObject);
		}

	}


}
