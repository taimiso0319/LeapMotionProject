using UnityEngine;
using System.Collections;

public class MoveSphere : MonoBehaviour {

	FingerPosition fingerPosition;
	public float x,y,z;
	public static readonly string[] FingerType = {"Thumb","Index","Middle","Ring","Pinky"};
	// Use this for initialization
	void Start () {
		fingerPosition = (FingerPosition)GameObject.Find("_Manager").GetComponent<FingerPosition>();
	}
	
	// Update is called once per frame
	void Update () {
		x=fingerPosition.rFingerPos.ring.distal.x;
		y=fingerPosition.rFingerPos.ring.distal.y;
		z=fingerPosition.rFingerPos.ring.distal.z;

		transform.position = new Vector3(x,y,z);
	}
}
