using UnityEngine;
using System.Collections;

public class OnDragImp : MonoBehaviour, DragControl.OnDragListener {

	private float c = 0.1f;
	private float width;

	void Start(){
		this.width = GetComponent<Renderer> ().bounds.size.x;
	}

	public void onDrag (float vertical, float horizontal)
	{
		//GetComponent<Rigidbody> ().AddForce (new Vector3(horizontal * 10,0,0));
		if((transform.position.x + (horizontal * c))> (-2 + (width / 2)) && (transform.position.x + (horizontal * c)) < (2 - (width/2)))
			transform.Translate (horizontal * c,0,0);
	}

	public void onRelease ()
	{
		stop ();
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "limits")
		{
			stop();
		}
	}

	private void stop(){
		//GetComponent<Rigidbody> ().velocity = Vector3.zero;
	}

}
