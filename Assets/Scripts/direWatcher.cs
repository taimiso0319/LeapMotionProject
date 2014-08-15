using UnityEngine;
using System.Collections;

public class direWatcher : MonoBehaviour {

	FingerPosition fingerPosition;
	public Vector3 vec;

	// Use this for initialization
	void Start () {
		fingerPosition = (FingerPosition)GameObject.Find("_Manager").GetComponent<FingerPosition>();
	}
	
	// Update is called once per frame
	void Update () {
		vec = new Vector3(fingerPosition.finDirX,fingerPosition.finDirY,fingerPosition.finDirZ);
	}
}
