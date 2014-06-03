using UnityEngine;
using System;
using System.Collections;
using Leap;

public class FingerPosition : MonoBehaviour {

	//public Finger.FingerType fingerType = Finger.FingerType.TYPE_INDEX;

	Controller controller = new Controller();

	public Vector3 local_position;
	public float rx = 0.0f;
	public float lx = 0.0f;
	// Use this for initialization

	public HandPositions handPos;
	public FingerPositions rFingerPos;
	public FingerPositions lFingerPos;

	void Start () {
		handPos = new HandPositions();
		rFingerPos = new FingerPositions();
		lFingerPos = new FingerPositions();
	}
	
	// Update is called once per frame
	void Update () {
		Frame frame = controller.Frame();
		HandList hands = frame.Hands;
		foreach(Hand hand in hands){
			if(hand.IsRight){
				handPos.right.x = hand.PalmPosition.x;
				handPos.right.y = hand.PalmPosition.y;
				handPos.right.z = hand.PalmPosition.z;
			}else{
				handPos.left.x = hand.PalmPosition.x;
				handPos.left.y = hand.PalmPosition.y;
				handPos.left.z = hand.PalmPosition.z;
			}
			FingerList fingers = hand.Fingers;
			foreach(Finger finger in fingers){
				Bone bone;
				Finger.FingerType fingertype = finger.Type();
				foreach (Bone.BoneType boneType in (Bone.BoneType[]) Enum.GetValues(typeof(Bone.BoneType)))
				{
					bone = finger.Bone(boneType);
					// ... Use bone
					if(hand.IsRight){
						switch(fingertype){
						case Finger.FingerType.TYPE_THUMB:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL: 
								rFingerPos.thumb.metacarpal.x = bone.NextJoint.x; 
								rFingerPos.thumb.metacarpal.y = bone.NextJoint.y;
								rFingerPos.thumb.metacarpal.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_PROXIMAL: 
								rFingerPos.thumb.proximal.x = bone.NextJoint.x;
								rFingerPos.thumb.proximal.y = bone.NextJoint.y;
								rFingerPos.thumb.proximal.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_INTERMEDIATE:
								rFingerPos.thumb.intermediate.x = bone.NextJoint.x;
								rFingerPos.thumb.intermediate.y = bone.NextJoint.y;
								rFingerPos.thumb.intermediate.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_DISTAL: 
								rFingerPos.thumb.distal.x = bone.NextJoint.x;
								rFingerPos.thumb.distal.x = bone.NextJoint.x;
								rFingerPos.thumb.distal.x = bone.NextJoint.x;
								break;
							}
							break;
						case Finger.FingerType.TYPE_INDEX:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL:
								rFingerPos.index.metacarpal.x = bone.NextJoint.x;
								rFingerPos.index.metacarpal.y = bone.NextJoint.y;
								rFingerPos.index.metacarpal.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_PROXIMAL: 
								rFingerPos.index.proximal.x = bone.NextJoint.x;
								rFingerPos.index.proximal.y = bone.NextJoint.y;
								rFingerPos.index.proximal.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_INTERMEDIATE: 
								rFingerPos.index.intermediate.x = bone.NextJoint.x;
								rFingerPos.index.intermediate.y = bone.NextJoint.y;
								rFingerPos.index.intermediate.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_DISTAL: 
								rFingerPos.index.distal.x = bone.NextJoint.x;
								rFingerPos.index.distal.y = bone.NextJoint.y;
								rFingerPos.index.distal.z = bone.NextJoint.z;
								break;
							}
							break;
						case Finger.FingerType.TYPE_MIDDLE:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL:
								rFingerPos.middle.metacarpal.x = bone.NextJoint.x;
								rFingerPos.middle.metacarpal.y = bone.NextJoint.y;
								rFingerPos.middle.metacarpal.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_PROXIMAL: 
								rFingerPos.middle.proximal.x = bone.NextJoint.x;
								rFingerPos.middle.proximal.y = bone.NextJoint.y;
								rFingerPos.middle.proximal.z = bone.NextJoint.z;
								break;

							case Bone.BoneType.TYPE_INTERMEDIATE: 
								rFingerPos.middle.intermediate.x = bone.NextJoint.x;
								rFingerPos.middle.intermediate.y = bone.NextJoint.y;
								rFingerPos.middle.intermediate.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_DISTAL: 
								rFingerPos.middle.distal.x = bone.NextJoint.x;
								rFingerPos.middle.distal.y = bone.NextJoint.y;
								rFingerPos.middle.distal.z = bone.NextJoint.z;
								break;
							}
							break;
						case Finger.FingerType.TYPE_RING:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL:
								rFingerPos.ring.metacarpal.x = bone.NextJoint.x;
								rFingerPos.ring.metacarpal.y = bone.NextJoint.y;
								rFingerPos.ring.metacarpal.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_PROXIMAL: 
								rFingerPos.ring.proximal.x = bone.NextJoint.x;
								rFingerPos.ring.proximal.y = bone.NextJoint.y;
								rFingerPos.ring.proximal.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_INTERMEDIATE:
								rFingerPos.ring.intermediate.x = bone.NextJoint.x;
								rFingerPos.ring.intermediate.y = bone.NextJoint.y;
								rFingerPos.ring.intermediate.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_DISTAL: 
								rFingerPos.ring.distal.x = bone.NextJoint.x;
								rFingerPos.ring.distal.y = bone.NextJoint.y;
								rFingerPos.ring.distal.z = bone.NextJoint.z;
								break;
							}
							break;
						case Finger.FingerType.TYPE_PINKY:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL: 
								rFingerPos.pinky.metacarpal.x = bone.NextJoint.x;
								rFingerPos.pinky.metacarpal.y = bone.NextJoint.y;
								rFingerPos.pinky.metacarpal.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_PROXIMAL:
								rFingerPos.pinky.proximal.x = bone.NextJoint.x;
								rFingerPos.pinky.proximal.y = bone.NextJoint.y;
								rFingerPos.pinky.proximal.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_INTERMEDIATE:
								rFingerPos.pinky.intermediate.x = bone.NextJoint.x;
								rFingerPos.pinky.intermediate.y = bone.NextJoint.y;
								rFingerPos.pinky.intermediate.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_DISTAL: 
								rFingerPos.pinky.distal.x = bone.NextJoint.x;
								rFingerPos.pinky.distal.y = bone.NextJoint.y;
								rFingerPos.pinky.distal.z = bone.NextJoint.z;
								break;
							}
							break;
						}
					}else{
						switch(fingertype){
						case Finger.FingerType.TYPE_THUMB:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL: 
								lFingerPos.thumb.metacarpal.x = bone.NextJoint.x;
								lFingerPos.thumb.metacarpal.y = bone.NextJoint.y;
								lFingerPos.thumb.metacarpal.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_PROXIMAL:
								lFingerPos.thumb.proximal.x = bone.NextJoint.x;
								lFingerPos.thumb.proximal.y = bone.NextJoint.y;
								lFingerPos.thumb.proximal.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_INTERMEDIATE: 
								lFingerPos.thumb.intermediate.x = bone.NextJoint.x;
								lFingerPos.thumb.intermediate.y = bone.NextJoint.y;
								lFingerPos.thumb.intermediate.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_DISTAL: 
								lFingerPos.thumb.distal.x = bone.NextJoint.x;
								lFingerPos.thumb.distal.y = bone.NextJoint.y;
								lFingerPos.thumb.distal.z = bone.NextJoint.z;
								break;
							}
							break;
						case Finger.FingerType.TYPE_INDEX:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL:
								lFingerPos.index.metacarpal.x = bone.NextJoint.x;
								lFingerPos.index.metacarpal.y = bone.NextJoint.y;
								lFingerPos.index.metacarpal.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_PROXIMAL:
								lFingerPos.index.proximal.x = bone.NextJoint.x;
								lFingerPos.index.proximal.y = bone.NextJoint.y;
								lFingerPos.index.proximal.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_INTERMEDIATE:
								lFingerPos.index.intermediate.x = bone.NextJoint.x;
								lFingerPos.index.intermediate.y = bone.NextJoint.y;
								lFingerPos.index.intermediate.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_DISTAL:
								lFingerPos.index.distal.x = bone.NextJoint.x;
								lFingerPos.index.distal.y = bone.NextJoint.y;
								lFingerPos.index.distal.z = bone.NextJoint.z;
								break;
							}
							break;
						case Finger.FingerType.TYPE_MIDDLE:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL:
								lFingerPos.middle.metacarpal.x = bone.NextJoint.x;
								lFingerPos.middle.metacarpal.y = bone.NextJoint.y;
								lFingerPos.middle.metacarpal.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_PROXIMAL:
								lFingerPos.middle.proximal.x = bone.NextJoint.x;
								lFingerPos.middle.proximal.y = bone.NextJoint.y;
								lFingerPos.middle.proximal.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_INTERMEDIATE:
								lFingerPos.middle.intermediate.x = bone.NextJoint.x;
								lFingerPos.middle.intermediate.y = bone.NextJoint.y;
								lFingerPos.middle.intermediate.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_DISTAL:
								lFingerPos.middle.distal.x = bone.NextJoint.x;
								lFingerPos.middle.distal.y = bone.NextJoint.y;
								lFingerPos.middle.distal.z = bone.NextJoint.z;
								break;
							}
							break;
						case Finger.FingerType.TYPE_RING:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL:
								lFingerPos.ring.metacarpal.x = bone.NextJoint.x;
								lFingerPos.ring.metacarpal.y = bone.NextJoint.y;
								lFingerPos.ring.metacarpal.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_PROXIMAL:
								lFingerPos.ring.proximal.x = bone.NextJoint.x;
								lFingerPos.ring.proximal.y = bone.NextJoint.y;
								lFingerPos.ring.proximal.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_INTERMEDIATE:
								lFingerPos.ring.intermediate.x = bone.NextJoint.x;
								lFingerPos.ring.intermediate.y = bone.NextJoint.y;
								lFingerPos.ring.intermediate.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_DISTAL:
								lFingerPos.ring.distal.x = bone.NextJoint.x;
								lFingerPos.ring.distal.y = bone.NextJoint.y;
								lFingerPos.ring.distal.z = bone.NextJoint.z;
								break;
							}
							break;
						case Finger.FingerType.TYPE_PINKY:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL:
								lFingerPos.pinky.metacarpal.x = bone.NextJoint.x;
								lFingerPos.pinky.metacarpal.y = bone.NextJoint.y;
								lFingerPos.pinky.metacarpal.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_PROXIMAL:
								lFingerPos.pinky.proximal.x = bone.NextJoint.x;
								lFingerPos.pinky.proximal.y = bone.NextJoint.y;
								lFingerPos.pinky.proximal.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_INTERMEDIATE:
								lFingerPos.pinky.intermediate.x = bone.NextJoint.x;
								lFingerPos.pinky.intermediate.y = bone.NextJoint.y;
								lFingerPos.pinky.intermediate.z = bone.NextJoint.z;
								break;
							case Bone.BoneType.TYPE_DISTAL:
								lFingerPos.pinky.distal.x = bone.NextJoint.x;
								lFingerPos.pinky.distal.y = bone.NextJoint.y;
								lFingerPos.pinky.distal.z = bone.NextJoint.z;
								break;
							}
							break;
						}
					}
				}
			}
		}
		rx = rFingerPos.thumb.metacarpal.x;
		lx = rFingerPos.thumb.metacarpal.y;
	}
	public class HandPositions{
		public Directions right; //x,y,z
		public Directions left;
		public HandPositions(){
			right = new Directions();
			left = new Directions();
		}
	}
	public class FingerPositions{
		public FingerJoints thumb;
		public FingerJoints index;
		public FingerJoints middle;
		public FingerJoints ring;
		public FingerJoints pinky;
		public FingerPositions(){
			thumb = new FingerJoints();
			index = new FingerJoints();
			middle = new FingerJoints();
			ring = new FingerJoints();
			pinky = new FingerJoints();
		}
	}
	public class FingerJoints{
		public Directions distal;
		public Directions intermediate;
		public Directions proximal;
		public Directions metacarpal;
		public FingerJoints(){
			distal = new Directions();
			intermediate = new Directions();
			proximal = new Directions();
			metacarpal = new Directions();
		}
	}
	public class Directions{
		public float x;
		public float y;
		public float z;
		public Directions(){
			x = 0.0f;
			y = 0.0f;
			z = 0.0f;
		}
	}
}