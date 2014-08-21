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
	
	public float finDirX;
	public float finDirY;
	public float finDirZ;

	public bool handExist = false;

	void Start () {
		handPos = new HandPositions();
		rFingerPos = new FingerPositions();
		lFingerPos = new FingerPositions();
	}
	
	// Update is called once per frame
	void Update () {
		Frame frame = controller.Frame();
		HandList hands = frame.Hands;
		if(frame.Hands.Count != 0)handExist = true;
		else handExist = false;
		foreach(Hand hand in hands){
			if(hand.IsRight){
				handPos.right.Vec = new Vector3(hand.PalmPosition.x,hand.PalmPosition.y,hand.PalmPosition.z);
			}else if(hand.IsLeft){
				handPos.left.Vec = new Vector3(hand.PalmPosition.x,hand.PalmPosition.y,hand.PalmPosition.z);
			}
			FingerList fingers = hand.Fingers;
			foreach(Finger finger in fingers){
				Bone bone;
				Finger.FingerType fingertype = finger.Type();
				if(fingertype == Finger.FingerType.TYPE_INDEX){
					finDirX = finger.Direction.x;
					finDirY = finger.Direction.y;
					finDirZ = finger.Direction.z;
				}

				foreach (Bone.BoneType boneType in (Bone.BoneType[]) Enum.GetValues(typeof(Bone.BoneType)))
				{
					bone = finger.Bone(boneType);
					// ... Use bone
					if(hand.IsRight){
						switch(fingertype){
						case Finger.FingerType.TYPE_THUMB:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL: 
								rFingerPos.thumb.metacarpal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_PROXIMAL: 
								rFingerPos.thumb.proximal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_INTERMEDIATE:
								rFingerPos.thumb.intermediate.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_DISTAL: 
								rFingerPos.thumb.distal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							}
							break;
						case Finger.FingerType.TYPE_INDEX:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL:
								rFingerPos.index.metacarpal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_PROXIMAL: 
								rFingerPos.index.proximal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_INTERMEDIATE: 
								rFingerPos.index.intermediate.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_DISTAL: 
								rFingerPos.index.distal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							}
							break;
						case Finger.FingerType.TYPE_MIDDLE:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL:
								rFingerPos.middle.metacarpal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_PROXIMAL: 
								rFingerPos.middle.proximal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;

							case Bone.BoneType.TYPE_INTERMEDIATE: 
								rFingerPos.middle.intermediate.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_DISTAL: 
								rFingerPos.middle.distal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							}
							break;
						case Finger.FingerType.TYPE_RING:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL:
								rFingerPos.ring.metacarpal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_PROXIMAL: 
								rFingerPos.ring.proximal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_INTERMEDIATE:
								rFingerPos.ring.intermediate.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_DISTAL: 
								rFingerPos.ring.distal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							}
							break;
						case Finger.FingerType.TYPE_PINKY:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL: 
								rFingerPos.pinky.metacarpal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_PROXIMAL:
								rFingerPos.pinky.proximal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_INTERMEDIATE:
								rFingerPos.pinky.intermediate.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_DISTAL: 
								rFingerPos.pinky.distal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							}
							break;
						}
					}else{
						switch(fingertype){
						case Finger.FingerType.TYPE_THUMB:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL: 
								lFingerPos.thumb.metacarpal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_PROXIMAL:
								lFingerPos.thumb.proximal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_INTERMEDIATE: 
								lFingerPos.thumb.intermediate.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_DISTAL: 
								lFingerPos.thumb.distal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							}
							break;
						case Finger.FingerType.TYPE_INDEX:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL:
								lFingerPos.index.metacarpal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_PROXIMAL:
								lFingerPos.index.proximal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_INTERMEDIATE:
								lFingerPos.index.intermediate.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_DISTAL:
								lFingerPos.index.distal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							}
							break;
						case Finger.FingerType.TYPE_MIDDLE:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL:
								lFingerPos.middle.metacarpal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_PROXIMAL:
								lFingerPos.middle.proximal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_INTERMEDIATE:
								lFingerPos.middle.intermediate.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_DISTAL:
								lFingerPos.middle.distal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							}
							break;
						case Finger.FingerType.TYPE_RING:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL:
								lFingerPos.ring.metacarpal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_PROXIMAL:
								lFingerPos.ring.proximal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_INTERMEDIATE:
								lFingerPos.ring.intermediate.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_DISTAL:
								lFingerPos.ring.distal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							}
							break;
						case Finger.FingerType.TYPE_PINKY:
							switch(boneType){
							case Bone.BoneType.TYPE_METACARPAL:
								lFingerPos.pinky.metacarpal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_PROXIMAL:
								lFingerPos.pinky.proximal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_INTERMEDIATE:
								lFingerPos.pinky.intermediate.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							case Bone.BoneType.TYPE_DISTAL:
								lFingerPos.pinky.distal.Vec = new Vector3(bone.NextJoint.x,bone.NextJoint.y,bone.NextJoint.z);
								break;
							}
							break;
						}
					}
				}
			}
		}
	}
	public class HandPositions{
		public Vectors right; //x,y,z
		public Vectors left;
		public HandPositions(){
			right = new Vectors();
			left = new Vectors();
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
		public Vectors distal;
		public Vectors intermediate;
		public Vectors proximal;
		public Vectors metacarpal;
		public FingerJoints(){
			distal = new Vectors();
			intermediate = new Vectors();
			proximal = new Vectors();
			metacarpal = new Vectors();
		}
	}
	public class Vectors{
		public Vector3 Vec;
		public Vector3 dirVec;
		public Vectors(){
			Vec = new Vector3();
			dirVec = new Vector3();
		}
	}
}