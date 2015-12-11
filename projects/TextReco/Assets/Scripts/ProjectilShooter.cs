using UnityEngine;
using System.Collections;
using Vuforia;
using System.Collections.Generic;
public class ProjectilShooter : MonoBehaviour
{


	GameObject prefab;
	// Use this for initialization
	void Start ()
	{
		prefab = Resources.Load ("Proyectil") as GameObject;
	}
	
	// Update is called once per frame
	void Update ()
	{
		bool displayed = false;
		StateManager sm = TrackerManager.Instance.GetStateManager ();
		IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours ();
		foreach (TrackableBehaviour tb in activeTrackables) {
			if (tb is ImageTargetBehaviour && tb.name == "qrGrisIT")
				displayed = true;
		}
		if (Input.GetMouseButtonDown (0) && displayed) {
			GameObject projectile = Instantiate (prefab) as GameObject;
			//projectile.transform.position = transform.position +  Camera.main.transform.forward*2;
			projectile.transform.position = GameObject.FindGameObjectWithTag ("MainCamera").transform.position + GameObject.FindGameObjectWithTag ("MainCamera").transform.forward * 2;
			Rigidbody rb = projectile.GetComponent<Rigidbody> ();
			rb.velocity = GameObject.FindGameObjectWithTag ("MainCamera").transform.forward * 40;
		}
	}
}
