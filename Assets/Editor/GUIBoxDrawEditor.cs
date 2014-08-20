using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(GUIBoxDraw))]

public class GUIBoxDrawEditor : Editor {
	
	private static readonly string[] Gui_Pos = {"upleft","up","upright","middleleft","middle","middleright","downleft","down","downright"};
	public override void OnInspectorGUI(){
		GUIBoxDraw GuiBD = target as GUIBoxDraw;
		GuiBD.Gui_Pos = EditorGUILayout.Popup("Gui_Pos",GuiBD.Gui_Pos,Gui_Pos);
	}
}
