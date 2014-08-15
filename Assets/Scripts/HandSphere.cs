using UnityEngine;
using System.Collections;

public class HandSphere : MonoBehaviour {

	FingerPosition fingerPosition;

	public bool Right;

	// Use this for initialization
	void Start () {
		fingerPosition = (FingerPosition)GameObject.Find("_Manager").GetComponent<FingerPosition>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Right)
			transform.position = new Vector3(
			fingerPosition.handPos.right.Vec.x,
			fingerPosition.handPos.right.Vec.y,
			-fingerPosition.handPos.right.Vec.z);
		else
			transform.position = new Vector3(
			fingerPosition.handPos.left.Vec.x,
			fingerPosition.handPos.left.Vec.y,
			-fingerPosition.handPos.left.Vec.z);
	}
}
