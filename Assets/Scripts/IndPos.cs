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
		if(130 < Vec.y){		pos = "up";		PlusLR();}
		else if(Vec.y < 70){ 	pos = "down";	PlusLR();}
		else{					pos = "middle";	PlusLR();}
		if(Input.GetKeyDown(KeyCode.Return))rightMode = !rightMode;
	}
	void PlusLR(){
		if(Vec.x < -20)		pos += "left";
		else if(20 < Vec.x)	pos += "right";
	}
	void UIAction(string finPos){
		switch(finPos){
		case "upleft":
			if(Button[0] != null){
				Button[0].GetComponent<UIButton>().OnHover(true);
			}
			break;
		case "middleft":
			break;
		case "downleft":
			break;
		case "up":
			break;
		case "middle":
			break;
		case "down":
			break;
		case "upright":
			break;
		case "middleright":
			break;
		case "downright":
			break;
		}
	}
}