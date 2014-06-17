using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(FingerPosition))]

public class FingerPositionEditor : Editor {

	private static readonly string[] Finger_Type = {"Thum","Index","Middle","Ring","Pinky"};
	private static readonly string[] Joint_Type = {"Metacarpal","Proximal","Intermediate","Distal"};

	public override void OnInspectorGUI(){
		FingerPosition FingerPosition = target as FingerPosition;
	//	FingerPosition.Finger_Type = EditorGUILayout.Popup("Finger_Type",FingerPosition.FingerPosition,Finger_Type);
	//	FingerPosition.Joint_Type = EditorGUILayout.Popup("Finger_Type",FingerPosition.FingerPosition,Joint_Type);
	}
}
