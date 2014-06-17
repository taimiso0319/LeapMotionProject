using UnityEngine;
using System.Collections;

public class MoveSphere2 : MonoBehaviour {

	FingerPosition fingerPosition;
	public float x,y,z;
	public int Hand_Type;
	public int Finger_Type;
	public int Joint_Type;
	// Use this for initialization
	void Start () {
		fingerPosition = (FingerPosition)GameObject.Find("_Manager").GetComponent<FingerPosition>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
