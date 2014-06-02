using UnityEngine;
using System;
using System.Collections;
using Leap;

public class Counter : MonoBehaviour {
	
	Controller controller;
	
	public int Hs;
	public int Fs;
	public float o;
	public float h;
	public float n;
	public float k;
	public float c;
	
	
	// Use this for initialization
	void Start () {
		controller = new Controller();
		
	}
	// Update is called once per frame
	void Update () {
		if(controller.IsConnected) //controller is a Controller object
		{
			Frame frame = controller.Frame();
			Hand hand = frame.Hand(0);
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