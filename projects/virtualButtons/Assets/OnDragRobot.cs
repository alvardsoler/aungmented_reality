using UnityEngine;
using System.Collections;

public class OnDragRobot : MonoBehaviour, DragControl.OnDragListener {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onDrag (float horiontal, float vertical)
	{
		gameObject.transform.Rotate(new Vector3(horiontal,vertical,0));
	}

}
