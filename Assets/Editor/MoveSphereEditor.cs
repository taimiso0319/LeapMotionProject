using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(MoveSphere))]

public class MoveSphereEditor : Editor {
	
	private static readonly string[] Hand_Type = {"Right","Left"};
	private static readonly string[] Finger_Type = {"Thum","Index","Middle","Ring","Pinky"};
	private static readonly string[] Joint_Type = {"Metacarpal","Proximal","Intermediate","Distal"};

	public override void OnInspectorGUI(){
		MoveSphere MoveSphere = target as MoveSphere;
		MoveSphere.Hand_Type = EditorGUILayout.Popup("Hand_Type",MoveSphere.Hand_Type,Hand_Type);
		MoveSphere.Finger_Type = EditorGUILayout.Popup("Finger_Type",MoveSphere.Finger_Type,Finger_Type);
		MoveSphere.Joint_Type = EditorGUILayout.Popup("Joint_Type",MoveSphere.Joint_Type,Joint_Type);
	}
}
