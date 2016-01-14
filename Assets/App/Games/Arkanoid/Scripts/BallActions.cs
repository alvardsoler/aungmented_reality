using UnityEngine;
using System.Collections;

public class BallActions : MonoBehaviour {

	public bool start = false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (!start && Input.touchCount > 0) {
			start = true;
			GetComponent<Rigidbody> ().AddForce(new Vector3(Input.touches[0].position.x * 0.1f,Input.touches[0].position.y * 0.1f,0f));
		}


	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "blocks")
		{
			Destroy(col.gameObject);
		}
	}
}
