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

	private bool soundPlay = true;

	private float timerCount = 3f;
	private float startTimer = 3f;

	private float widthPos;
	private float heightPos;
	
	TextMesh countDownGui;
	GameObject childGuiText;
	TextMesh childGuiMesh;
	GameObject mainCamera;
	FingerPosition fingerPosition;
	

	void Start(){
		countDownGui = this.transform.FindChild("CountDownGUI").GetComponent<TextMesh>();
		fingerPosition = (FingerPosition)GameObject.Find("_Manager").GetComponent<FingerPosition>();
		indPos = (IndPos)GameObject.Find("IndPos").GetComponent<IndPos>();
		childGuiText = this.transform.FindChild("GUI").gameObject;
		childGuiMesh = this.transform.FindChild("GUI").GetComponent<TextMesh>();
		mainCamera = GameObject.Find("Main Camera").gameObject;
	}

	void OnGUI(){
		widthPos = Screen.width/3;
		heightPos = Screen.height/3;
		switch(Gui_Pos){
		case 0:
			childGuiMesh.text = "おはよう";
			meshColor("UpLeft");
			childGuiText.transform.position = mainCamera.camera.ScreenToWorldPoint(new Vector3(widthPos-widthPos/2,heightPos*3-heightPos/2,0)) + new Vector3(0,0,5);
			GUI.Box(new Rect(0,0,widthPos,heightPos),"");
			break;
		case 1:
			childGuiMesh.text = "こんにちは";
			meshColor("Up");
			childGuiText.transform.position = mainCamera.camera.ScreenToWorldPoint(new Vector3(widthPos*2-widthPos/2,heightPos*3-heightPos/2,0)) + new Vector3(0,0,5);
			GUI.Box(new Rect(widthPos,0,widthPos,heightPos),"");
			break;
		case 2:
			childGuiMesh.text = "こんばんは";
			meshColor("UpRight");
			childGuiText.transform.position = mainCamera.camera.ScreenToWorldPoint(new Vector3(widthPos*3-widthPos/2,heightPos*3-heightPos/2,0)) + new Vector3(0,0,5);
			GUI.Box(new Rect(widthPos*2,0,widthPos,heightPos),"");
			break;
		case 3:
			childGuiMesh.text = "お腹がすいた";
			meshColor("MiddleLeft");
			childGuiText.transform.position = mainCamera.camera.ScreenToWorldPoint(new Vector3(widthPos-widthPos/2,heightPos*2-heightPos/2,0)) + new Vector3(0,0,5);
			GUI.Box(new Rect(0,heightPos,widthPos,heightPos),"");
			break;
		case 4:
			childGuiMesh.text = "喉が渇いた";
			meshColor("Middle");
			childGuiText.transform.position = mainCamera.camera.ScreenToWorldPoint(new Vector3(widthPos*2-widthPos/2,heightPos*2-heightPos/2,0)) + new Vector3(0,0,5);
			GUI.Box(new Rect(widthPos,heightPos,widthPos,heightPos),"");
			break;
		case 5: 
			childGuiMesh.text = "ありがとう";
			meshColor("MiddleRight");
			childGuiText.transform.position = mainCamera.camera.ScreenToWorldPoint(new Vector3(widthPos*3-widthPos/2,heightPos*2-heightPos/2,0)) + new Vector3(0,0,5);
			GUI.Box(new Rect(widthPos*2,heightPos,widthPos,heightPos),"");
			break;
		case 6:
			childGuiMesh.text = "はい";
			meshColor("DownLeft");
			childGuiText.transform.position = mainCamera.camera.ScreenToWorldPoint(new Vector3(widthPos-widthPos/2,heightPos-heightPos/2,0)) + new Vector3(0,0,5);
			GUI.Box(new Rect(0,heightPos*2,widthPos,heightPos),"");
			break;
		case 7:
			childGuiMesh.text = "いいえ";
			meshColor("Down");
			childGuiText.transform.position = mainCamera.camera.ScreenToWorldPoint(new Vector3(widthPos*2-widthPos/2,heightPos-heightPos/2,0)) + new Vector3(0,0,5);
			GUI.Box(new Rect(widthPos,heightPos*2,widthPos,heightPos),"");
			break;
		case 8:
			childGuiMesh.text = "どちらでもない";
			meshColor("DownRight");
			childGuiText.transform.position = mainCamera.camera.ScreenToWorldPoint(new Vector3(widthPos*3-widthPos/2,heightPos-heightPos/2,0)) + new Vector3(0,0,5);
			GUI.Box(new Rect(widthPos*2,heightPos*2,widthPos,heightPos),"");
			break;
		}
	}
	void meshColor(string pos){
		if(indPos.pos == pos && fingerPosition.handExist){
			childGuiMesh.color = new Color(0.6f,1f,0.6f,0.8f);
			if(timerCount>0)timerCount -= Time.deltaTime/2;
			countDown(timerCount.ToString("F0"),Gui_Pos);
		}else{
			childGuiMesh.color = Color.white;
			countDown(null);
			timerCount = startTimer;
		}
	}

	void countDown(string count,int soundNum){
		countDownGui.text = count;
		if(soundPlay && count.Equals("0")){
			audio.Play();
			soundPlay = false;
		}
	}
	void countDown(string count){
		countDownGui.text = count;
		soundPlay = true;
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
