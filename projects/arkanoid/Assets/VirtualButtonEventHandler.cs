using UnityEngine;
using System.Collections.Generic;
using Vuforia;

/**
 * Clase de ejemplo para manejar el comportamiento de botones virtuales.
 */
public class VirtualButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler
{
	

	/**
	 * GameObject sobre el que queremos actuar
	 */
	public GameObject robot;
	private GameObject btn_1;
	private GameObject btn_2;
	/// Called when the scene is loaded
	void Start ()
	{
		
		// Search for all Children from this ImageTarget with type VirtualButtonBehaviour
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour> ();
		for (int i = 0; i < vbs.Length; ++i) {	
			vbs [i].RegisterEventHandler (this);
		}

		// Find the models based on the names in the Hierarchy	
	}
	
	/// <summary>
	/// Called when the virtual button has just been pressed:
	/// </summary>
	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb)
	{

		Debug.Log ("Button pressed!");


		switch (vb.VirtualButtonName) {
		case "vb_1":
			robot.SetActive (false);
			break;
		case "vb_2":
			robot.SetActive (true);
			break;
		}
		
	}
	
	/// Called when the virtual button has just been released:
	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb)
	{ 
		Debug.Log ("Button released!");
	}
}