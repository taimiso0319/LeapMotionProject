using UnityEngine;
using System.Collections;

public class GUIBoxDraw : MonoBehaviour {
	/*
	private GUIStyle MyStyleGreen = null;
	private GUIStyle MyStyleWhite = null;
	*/
	public int Gui_Pos;

	/*
	 * Gui_Pos Num;
	 * 
	 * 0 - UpLeft
	 * 1 - Up
	 * 2 - UpRight
	 * 3 - MiddleLeft
	 * 4 - Middle
	 * 5 - MiddleRight
	 * 6 - DownLeft
	 * 7 - Down
	 * 8 - DownRight
	 * 
	 */

	public IndPos indPos;

	private float widthPos;
	private float heightPos;
	
	private float textPosX = 0.165f;
	private float textPosY = 0.1665f;

	GameObject childGuiText;

	void Start(){
		indPos = (IndPos)GameObject.Find("IndPos").GetComponent<IndPos>();
		childGuiText = this.transform.FindChild("GUI").gameObject;
	}

	void OnGUI(){
		widthPos = Screen.width/3;
		heightPos = Screen.height/3;
		switch(Gui_Pos){
		case 0:
			childGuiText.guiText.text = "おはよう";
			childGuiText.transform.position = new Vector2(textPosX,textPosY * 5);
			GUI.Box(new Rect(0,0,widthPos,heightPos),"");
			break;
		case 1:
			childGuiText.guiText.text = "こんにちは";
			childGuiText.transform.position = new Vector2(textPosX * 3,textPosY * 5);
			GUI.Box(new Rect(widthPos,0,widthPos,heightPos),"");
			break;
		case 2:
			childGuiText.guiText.text = "こんばんは";
			childGuiText.transform.position = new Vector2(textPosX * 5,textPosY * 5);
			GUI.Box(new Rect(widthPos*2,0,widthPos,heightPos),"");
			break;
		case 3:
			childGuiText.guiText.text = "お腹がすいた";
			childGuiText.transform.position = new Vector2(textPosX,textPosY * 3);
			GUI.Box(new Rect(0,heightPos,widthPos,heightPos),"");
			break;
		case 4:
			childGuiText.guiText.text = "喉が渇いた";
			childGuiText.transform.position = new Vector2(textPosX * 3,textPosY * 3);
			GUI.Box(new Rect(widthPos,heightPos,widthPos,heightPos),"");
			break;
		case 5: 
			childGuiText.guiText.text = "トイレに行きたい";
			childGuiText.transform.position = new Vector2(textPosX * 5,textPosY * 3);
			GUI.Box(new Rect(widthPos*2,heightPos,widthPos,heightPos),"");
			break;
		case 6:
			childGuiText.guiText.text = "はい";
			childGuiText.transform.position = new Vector2(textPosX,textPosY);
			GUI.Box(new Rect(0,heightPos*2,widthPos,heightPos),"");
			break;
		case 7:
			childGuiText.guiText.text = "いいえ";
			childGuiText.transform.position = new Vector2(textPosX * 3,textPosY);
			GUI.Box(new Rect(widthPos,heightPos*2,widthPos,heightPos),"");
			break;
		case 8:
			childGuiText.guiText.text = "どちらでもない";
			childGuiText.transform.position = new Vector2(textPosX * 5,textPosY);
			GUI.Box(new Rect(widthPos*2,heightPos*2,widthPos,heightPos),"");
			break;
		}
	}
	/*
	private void InitStyle(){
		if(MyStyleGreen == null){
			MyStyleGreen = new GUIStyle(GUI.skin.box);
			MyStyleWhite = new GUIStyle(GUI.skin.box);
			MyStyleGreen.normal.background = MakeTex(2, 2, new Color(0f,1f,0f,0.5f));
			MyStyleWhite.normal.background = MakeTex(2, 2, new Color(1f,1f,1f,0f));
		}
	}
	private Texture2D MakeTex(int width, int height, Color col){
		Color[] pix = new Color[width * height];
		for(int i = 0; i < pix.Length; ++i){
			pix[ i ] = col;
		}
		Texture2D result = new Texture2D(width,height);
		result.SetPixels(pix);
		result.Apply();
		return result;
	}
	*/
	
}
