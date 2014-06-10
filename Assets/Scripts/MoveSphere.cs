using UnityEngine;
using System.Collections;

public class MoveSphere : MonoBehaviour {

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
		if(Hand_Type == 0){
			switch(Finger_Type){
				case 0:
					switch(Joint_Type){
					case 0:
						x=fingerPosition.rFingerPos.thumb.metacarpal.x;
						y=fingerPosition.rFingerPos.thumb.metacarpal.y;
						z=fingerPosition.rFingerPos.thumb.metacarpal.z;
						break;
					case 1:
						x=fingerPosition.rFingerPos.thumb.proximal.x;
						y=fingerPosition.rFingerPos.thumb.proximal.y;
						z=fingerPosition.rFingerPos.thumb.proximal.z;
						break;
					case 2:
						x=fingerPosition.rFingerPos.thumb.intermediate.x;
						y=fingerPosition.rFingerPos.thumb.intermediate.y;
						z=fingerPosition.rFingerPos.thumb.intermediate.z;
						break;
					case 3:
						x=fingerPosition.rFingerPos.thumb.distal.x;
						y=fingerPosition.rFingerPos.thumb.distal.y;
						z=fingerPosition.rFingerPos.thumb.distal.z;
					break;
					}
				break;
				case 1:
					switch(Joint_Type){
					case 0:
						x=fingerPosition.rFingerPos.index.metacarpal.x;
						y=fingerPosition.rFingerPos.index.metacarpal.y;
						z=fingerPosition.rFingerPos.index.metacarpal.z;
						break;
					case 1:
						x=fingerPosition.rFingerPos.index.proximal.x;
						y=fingerPosition.rFingerPos.index.proximal.y;
						z=fingerPosition.rFingerPos.index.proximal.z;
						break;
					case 2:
						x=fingerPosition.rFingerPos.index.intermediate.x;
						y=fingerPosition.rFingerPos.index.intermediate.y;
						z=fingerPosition.rFingerPos.index.intermediate.z;
						break;
					case 3:
						x=fingerPosition.rFingerPos.index.distal.x;
						y=fingerPosition.rFingerPos.index.distal.y;
						z=fingerPosition.rFingerPos.index.distal.z;
						break;
					}
				break;
				case 2:
				switch(Joint_Type){
					case 0:
						x=fingerPosition.rFingerPos.middle.metacarpal.x;
						y=fingerPosition.rFingerPos.middle.metacarpal.y;
						z=fingerPosition.rFingerPos.middle.metacarpal.z;
						break;
					case 1:
						x=fingerPosition.rFingerPos.middle.proximal.x;
						y=fingerPosition.rFingerPos.middle.proximal.y;
						z=fingerPosition.rFingerPos.middle.proximal.z;
						break;
					case 2:
						x=fingerPosition.rFingerPos.middle.intermediate.x;
						y=fingerPosition.rFingerPos.middle.intermediate.y;
						z=fingerPosition.rFingerPos.middle.intermediate.z;
						break;
					case 3:
						x=fingerPosition.rFingerPos.middle.distal.x;
						y=fingerPosition.rFingerPos.middle.distal.y;
						z=fingerPosition.rFingerPos.middle.distal.z;
						break;
					}
				break;
				case 3:
				switch(Joint_Type){
					case 0:
						x=fingerPosition.rFingerPos.ring.metacarpal.x;
						y=fingerPosition.rFingerPos.ring.metacarpal.y;
						z=fingerPosition.rFingerPos.ring.metacarpal.z;
						break;
					case 1:
						x=fingerPosition.rFingerPos.ring.proximal.x;
						y=fingerPosition.rFingerPos.ring.proximal.y;
						z=fingerPosition.rFingerPos.ring.proximal.z;
						break;
					case 2:
						x=fingerPosition.rFingerPos.ring.intermediate.x;
						y=fingerPosition.rFingerPos.ring.intermediate.y;
						z=fingerPosition.rFingerPos.ring.intermediate.z;
						break;
					case 3:
						x=fingerPosition.rFingerPos.ring.distal.x;
						y=fingerPosition.rFingerPos.ring.distal.y;
						z=fingerPosition.rFingerPos.ring.distal.z;
						break;
					}
				break;
				case 4:
				switch(Joint_Type){
					case 0:
						x=fingerPosition.rFingerPos.pinky.metacarpal.x;
						y=fingerPosition.rFingerPos.pinky.metacarpal.y;
						z=fingerPosition.rFingerPos.pinky.metacarpal.z;
						break;
					case 1:
						x=fingerPosition.rFingerPos.pinky.proximal.x;
						y=fingerPosition.rFingerPos.pinky.proximal.y;
						z=fingerPosition.rFingerPos.pinky.proximal.z;
						break;
					case 2:
						x=fingerPosition.rFingerPos.pinky.intermediate.x;
						y=fingerPosition.rFingerPos.pinky.intermediate.y;
						z=fingerPosition.rFingerPos.pinky.intermediate.z;
						break;
					case 3:
						x=fingerPosition.rFingerPos.pinky.distal.x;
						y=fingerPosition.rFingerPos.pinky.distal.y;
						z=fingerPosition.rFingerPos.pinky.distal.z;
						break;
					}
				break;
			}
		}else{
			switch(Finger_Type){
			case 0:
				switch(Joint_Type){
				case 0:
					x=fingerPosition.lFingerPos.thumb.metacarpal.x;
					y=fingerPosition.lFingerPos.thumb.metacarpal.y;
					z=fingerPosition.lFingerPos.thumb.metacarpal.z;
					break;
				case 1:
					x=fingerPosition.lFingerPos.thumb.proximal.x;
					y=fingerPosition.lFingerPos.thumb.proximal.y;
					z=fingerPosition.lFingerPos.thumb.proximal.z;
					break;
				case 2:
					x=fingerPosition.lFingerPos.thumb.intermediate.x;
					y=fingerPosition.lFingerPos.thumb.intermediate.y;
					z=fingerPosition.lFingerPos.thumb.intermediate.z;
					break;
				case 3:
					x=fingerPosition.lFingerPos.thumb.distal.x;
					y=fingerPosition.lFingerPos.thumb.distal.y;
					z=fingerPosition.lFingerPos.thumb.distal.z;
					break;
				}
				break;
			case 1:
				switch(Joint_Type){
				case 0:
					x=fingerPosition.lFingerPos.index.metacarpal.x;
					y=fingerPosition.lFingerPos.index.metacarpal.y;
					z=fingerPosition.lFingerPos.index.metacarpal.z;
					break;
				case 1:
					x=fingerPosition.lFingerPos.index.proximal.x;
					y=fingerPosition.lFingerPos.index.proximal.y;
					z=fingerPosition.lFingerPos.index.proximal.z;
					break;
				case 2:
					x=fingerPosition.lFingerPos.index.intermediate.x;
					y=fingerPosition.lFingerPos.index.intermediate.y;
					z=fingerPosition.lFingerPos.index.intermediate.z;
					break;
				case 3:
					x=fingerPosition.lFingerPos.index.distal.x;
					y=fingerPosition.lFingerPos.index.distal.y;
					z=fingerPosition.lFingerPos.index.distal.z;
					break;
				}
				break;
			case 2:
				switch(Joint_Type){
				case 0:
					x=fingerPosition.lFingerPos.middle.metacarpal.x;
					y=fingerPosition.lFingerPos.middle.metacarpal.y;
					z=fingerPosition.lFingerPos.middle.metacarpal.z;
					break;
				case 1:
					x=fingerPosition.lFingerPos.middle.proximal.x;
					y=fingerPosition.lFingerPos.middle.proximal.y;
					z=fingerPosition.lFingerPos.middle.proximal.z;
					break;
				case 2:
					x=fingerPosition.lFingerPos.middle.intermediate.x;
					y=fingerPosition.lFingerPos.middle.intermediate.y;
					z=fingerPosition.lFingerPos.middle.intermediate.z;
					break;
				case 3:
					x=fingerPosition.lFingerPos.middle.distal.x;
					y=fingerPosition.lFingerPos.middle.distal.y;
					z=fingerPosition.lFingerPos.middle.distal.z;
					break;
				}
				break;
			case 3:
				switch(Joint_Type){
				case 0:
					x=fingerPosition.lFingerPos.ring.metacarpal.x;
					y=fingerPosition.lFingerPos.ring.metacarpal.y;
					z=fingerPosition.lFingerPos.ring.metacarpal.z;
					break;
				case 1:
					x=fingerPosition.lFingerPos.ring.proximal.x;
					y=fingerPosition.lFingerPos.ring.proximal.y;
					z=fingerPosition.lFingerPos.ring.proximal.z;
					break;
				case 2:
					x=fingerPosition.lFingerPos.ring.intermediate.x;
					y=fingerPosition.lFingerPos.ring.intermediate.y;
					z=fingerPosition.lFingerPos.ring.intermediate.z;
					break;
				case 3:
					x=fingerPosition.lFingerPos.ring.distal.x;
					y=fingerPosition.lFingerPos.ring.distal.y;
					z=fingerPosition.lFingerPos.ring.distal.z;
					break;
				}
				break;
			case 4:
				switch(Joint_Type){
				case 0:
					x=fingerPosition.lFingerPos.pinky.metacarpal.x;
					y=fingerPosition.lFingerPos.pinky.metacarpal.y;
					z=fingerPosition.lFingerPos.pinky.metacarpal.z;
					break;
				case 1:
					x=fingerPosition.lFingerPos.pinky.proximal.x;
					y=fingerPosition.lFingerPos.pinky.proximal.y;
					z=fingerPosition.lFingerPos.pinky.proximal.z;
					break;
				case 2:
					x=fingerPosition.lFingerPos.pinky.intermediate.x;
					y=fingerPosition.lFingerPos.pinky.intermediate.y;
					z=fingerPosition.lFingerPos.pinky.intermediate.z;
					break;
				case 3:
					x=fingerPosition.lFingerPos.pinky.distal.x;
					y=fingerPosition.lFingerPos.pinky.distal.y;
					z=fingerPosition.lFingerPos.pinky.distal.z;
					break;
				}
				break;
			}
		}
		transform.position = new Vector3(x,y,-z);
	}
}
