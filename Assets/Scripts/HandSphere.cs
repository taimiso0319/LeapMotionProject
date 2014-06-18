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
		if(Right){
			transform.position = new Vector3(fingerPosition.handPos.right.x,fingerPosition.handPos.right.y,-fingerPosition.handPos.right.z);
		}else{
			transform.position = new Vector3(fingerPosition.handPos.left.x,fingerPosition.handPos.left.y,-fingerPosition.handPos.left.z);
		}
	}
}
