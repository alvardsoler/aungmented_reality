using UnityEngine;
using System.Collections;

/**
 * Clase para gestionar la GUI.
 * 
 */
public class GUICode : MonoBehaviour
{
	public GameObject robot;
	// Use this for initialization
	float startTime;
	Vector2 startPos;
	bool couldBeSwipe;
	float comfortZone;
	float minSwipeDist;
	float maxSwipeTime;

	void Start ()
	{
		//robot = GameObject.Find("robot_kyle").gameObject;
	}
	
	// Update is called once per frame
	void Update ()
	{
		// Para que se cierre la aplicacion al pulsar el boton de return del movil
		if (Application.platform == RuntimePlatform.Android) {			
			if (Input.GetKeyUp (KeyCode.Escape)) {
				Application.Quit ();				
				return;				
			}
		}
	}

	void OnGUI ()
	{
		GUI.backgroundColor = Color.clear;
		
		/*foreach (Touch touch in Input.touches) {
			if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Stationary) {
				// Construct a ray from the current touch coordinates
				if (touch.position.x <= (Screen.width /2))
					robot.transform.Rotate (new Vector3(0,-1,0));
				if (touch.position.x > (Screen.width /2))
					robot.transform.Rotate (new Vector3(0,1,0));
			}
		}*/

		//GUI.Box (new Rect(0,0,1000,200), "Button");
		/*if (GUI.RepeatButton (new Rect (0, 0, Screen.width/2, Screen.height), "")) {
			//robot.SetActive(true);
			robot.transform.Rotate (new Vector3(0,-1,0));

		}

		if (GUI.RepeatButton (new Rect (Screen.width/2, 0, Screen.width/2, Screen.height), "")) {
			//robot.SetActive(false);
			robot.transform.Rotate (new Vector3(0,1,0));
		}*/

		
	}


}

