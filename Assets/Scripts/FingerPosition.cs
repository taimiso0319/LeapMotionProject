using UnityEngine;
using System;
using System.Collections;
using Leap;

public class FingerPosition : MonoBehaviour {

	//public Finger.FingerType fingerType = Finger.FingerType.TYPE_INDEX;

	Controller controller = new Controller();

	public Vector3 local_position;
	public float x = 0.0f;
	// Use this for initialization
	public float[][][] hanfinPos = new float[2][][]; //[hands][fingers][metacarpals]
	void Start () {
		for(int i = 0; i < 2; i++){
			hanfinPos[i] = new float[5][];
			for(int j = 0; j < 5; j++){
				hanfinPos[i][j] = new float[4];
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		Frame frame = controller.Frame();
		HandList hands = frame.Hands;
		foreach(Hand hand in hands){
			FingerList fingers = hand.Fingers;
			foreach(Finger finger in fingers){
				Bone bone;
				foreach (Bone.BoneType boneType in (Bone.BoneType[]) Enum.GetValues(typeof(Bone.BoneType)))
				{
					bone = finger.Bone(boneType);
					// ... Use bone
				}
			}
		}
	}
}
