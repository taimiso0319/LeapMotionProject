using UnityEngine;
using System.Collections;

public class MoveSphere : MonoBehaviour {

	FingerPosition fingerPosition;
	public Vector3 Vec;
	public int Hand_Type;
	public int Finger_Type;
	public int Joint_Type;
	// Use this for initialization
	void Start () {
		fingerPosition = (FingerPosition)GameObject.Find("_Manager").GetComponent<FingerPosition>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Hand_Type == 0){
			switch(Finger_Type){
				case 0:
					switch(Joint_Type){
						case 0:	Vec=fingerPosition.rFingerPos.thumb.metacarpal.Vec;		break;
						case 1:	Vec=fingerPosition.rFingerPos.thumb.proximal.Vec;		break;
						case 2:	Vec=fingerPosition.rFingerPos.thumb.intermediate.Vec;	break;
						case 3:	Vec=fingerPosition.rFingerPos.thumb.distal.Vec;			break;
					}
				break;
				case 1:
					switch(Joint_Type){
						case 0: Vec=fingerPosition.rFingerPos.index.metacarpal.Vec;		break;
						case 1:	Vec=fingerPosition.rFingerPos.index.proximal.Vec;		break;
						case 2: Vec=fingerPosition.rFingerPos.index.intermediate.Vec;   break;
						case 3: Vec=fingerPosition.rFingerPos.index.distal.Vec;			break;
					}
				break;
				case 2:
				switch(Joint_Type){
						case 0: Vec=fingerPosition.rFingerPos.middle.metacarpal.Vec;	break;
						case 1:	Vec=fingerPosition.rFingerPos.middle.proximal.Vec;		break;
						case 2:	Vec=fingerPosition.rFingerPos.middle.intermediate.Vec;	break;
						case 3:	Vec=fingerPosition.rFingerPos.middle.distal.Vec;		break;
					}
				break;
				case 3:
				switch(Joint_Type){
						case 0:	Vec=fingerPosition.rFingerPos.ring.metacarpal.Vec;		break;
						case 1:	Vec=fingerPosition.rFingerPos.ring.proximal.Vec;		break;
						case 2:	Vec=fingerPosition.rFingerPos.ring.intermediate.Vec;	break;
						case 3:	Vec=fingerPosition.rFingerPos.ring.distal.Vec;			break;
					}
				break;
				case 4:
				switch(Joint_Type){
						case 0:	Vec=fingerPosition.rFingerPos.pinky.metacarpal.Vec;		break;
						case 1:	Vec=fingerPosition.rFingerPos.pinky.proximal.Vec;		break;
						case 2: Vec=fingerPosition.rFingerPos.pinky.intermediate.Vec;	break;
						case 3:	Vec=fingerPosition.rFingerPos.pinky.distal.Vec;			break;
					}
				break;
			}
		}else{
			switch(Finger_Type){
				case 0:
					switch(Joint_Type){
						case 0: Vec=fingerPosition.lFingerPos.thumb.metacarpal.Vec;		break;
						case 1: Vec=fingerPosition.lFingerPos.thumb.proximal.Vec; 		break;
						case 2: Vec=fingerPosition.lFingerPos.thumb.intermediate.Vec;	break;
						case 3: Vec=fingerPosition.lFingerPos.thumb.distal.Vec;			break;
					}
				break;
				case 1:
					switch(Joint_Type){
						case 0: Vec=fingerPosition.lFingerPos.index.metacarpal.Vec;		break;
						case 1: Vec=fingerPosition.lFingerPos.index.proximal.Vec;		break;
						case 2: Vec=fingerPosition.lFingerPos.index.intermediate.Vec;	break;
						case 3: Vec=fingerPosition.lFingerPos.index.distal.Vec;			break;
					}
				break;
				case 2:
					switch(Joint_Type){
						case 0: Vec=fingerPosition.lFingerPos.middle.metacarpal.Vec;	break;
						case 1: Vec=fingerPosition.lFingerPos.middle.proximal.Vec;		break;
						case 2: Vec=fingerPosition.lFingerPos.middle.intermediate.Vec;	break;
						case 3: Vec=fingerPosition.lFingerPos.middle.distal.Vec;		break;
					}
				break;
				case 3:
					switch(Joint_Type){
						case 0: Vec=fingerPosition.lFingerPos.ring.metacarpal.Vec;		break;
						case 1: Vec=fingerPosition.lFingerPos.ring.proximal.Vec;		break;
						case 2:	Vec=fingerPosition.lFingerPos.ring.intermediate.Vec;	break;
						case 3: Vec=fingerPosition.lFingerPos.ring.distal.Vec;			break;
					}
				break;
				case 4:
					switch(Joint_Type){
						case 0: Vec=fingerPosition.lFingerPos.pinky.metacarpal.Vec;		break;
						case 1: Vec=fingerPosition.lFingerPos.pinky.proximal.Vec;		break;
						case 2: Vec=fingerPosition.lFingerPos.pinky.intermediate.Vec;	break;
						case 3: Vec=fingerPosition.lFingerPos.pinky.distal.Vec;			break;
					}
				break;
			}
		}
		transform.position = new Vector3(Vec.x,Vec.y,-Vec.z);
	}
}
