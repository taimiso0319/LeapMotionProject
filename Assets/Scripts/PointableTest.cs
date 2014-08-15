using UnityEngine;
using System.Collections;
using Leap;

public class PointableTest : MonoBehaviour {
	
	Controller con = new Controller();

	public GameObject tip;

	public Vector pVector;
	public float test;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Frame frame = con.Frame();
		Pointable pointable = frame.Pointables.Frontmost;
		pVector = pointable.Direction;
		if(tip != null){
			tip.transform.position = new Vector3(pVector.x,pVector.y,pVector.z);
		}
	}
}
