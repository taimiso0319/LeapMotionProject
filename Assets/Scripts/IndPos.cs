using UnityEngine;
using System.Collections;

public class IndPos : MonoBehaviour {

	public bool rightMode = true;

	public GameObject[] Button;

	public string pos;

	public Vector3 Vec;

	FingerPosition fingerPosition;

	// Use this for initialization
	void Start () {
		fingerPosition = (FingerPosition)GameObject.Find("_Manager").GetComponent<FingerPosition>();

	}
	
	// Update is called once per frame
	void Update () {
		if(rightMode)Vec = fingerPosition.rFingerPos.index.distal.Vec;
		else Vec = fingerPosition.lFingerPos.index.distal.Vec;
		if(120 < Vec.y){		pos = "Up";		PlusLR();}
		else if(Vec.y < 80){ 	pos = "Down";	PlusLR();}
		else{					pos = "Middle";	PlusLR();}
		if(Input.GetKeyDown(KeyCode.Return))rightMode = !rightMode;
	}
	void PlusLR(){
		if(Vec.x < -18)		pos += "Left";
		else if(18 < Vec.x)	pos += "Right";
	}
	void UIAction(string finPos){
		switch(finPos){
		case "UpLeft":
			break;
		case "MiddLeft":
			break;
		case "DownLeft":
			break;
		case "Up":
			break;
		case "Middle":
			break;
		case "Down":
			break;
		case "UpRight":
			break;
		case "MiddleRight":
			break;
		case "DownRight":
			break;
		}
	}
}