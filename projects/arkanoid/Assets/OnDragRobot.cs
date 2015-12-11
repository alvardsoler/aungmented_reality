using UnityEngine;
using System.Collections;

public class OnDragRobot : MonoBehaviour, DragControl.OnDragListener {
	
	public void onDrag (float horiontal, float vertical)
	{
		gameObject.transform.Rotate(new Vector3(horiontal * 10,vertical * 10 ,0));
	}

	public void onRelease ()
	{

	}

}
