using UnityEngine;
using System;
using System.IO;
using System.Collections;

public class ExcelWriter : MonoBehaviour {

	StreamWriter streamWriter;
	AngleCalXZ angleCal;

	public GameObject calFingerObject;
	public string currentPath;
	public bool write = false;

	// Use this for initialization
	void Start () {
		currentPath = System.IO.Directory.GetCurrentDirectory();
		angleCal = calFingerObject.GetComponent<AngleCalXZ>();
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Return)){
			write = !write;
			System.IO.Directory.SetCurrentDirectory(currentPath);
			if(write)streamWriter = new StreamWriter(@"Assets/Excels/" +
			                                         System.DateTimeOffset.Now.Year.ToString()   +
			                                         "年" +
			                                         System.DateTimeOffset.Now.Month.ToString()  +
			                                         "月" +
			                                         System.DateTimeOffset.Now.Day.ToString()	 +
			                                         "日" +
			                                         System.DateTimeOffset.Now.Hour.ToString() 	 +
			                                         "時" +
			                                         System.DateTimeOffset.Now.Minute.ToString() +
			                                         "分" +
			                                         System.DateTimeOffset.Now.Second.ToString() +
			                                         "秒" +
			                                         ".csv");
			else streamWriter.Close();
		}
	}
	// Update is called once per frame
	void FixedUpdate () {
//		string[] tmpData = {
//			angleCal.angleStr
//		};
//		string writeData = string.Join(",",tmpData);
		if(write){
			streamWriter.WriteLine(angleCal.angleStr);
		}
	}
}
