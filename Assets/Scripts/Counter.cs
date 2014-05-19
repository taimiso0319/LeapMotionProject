using UnityEngine;
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
			Frame frame = controller.Frame(); // controller is a Controller object
			HandList hands = frame.Hands;
			Hs = hands.Count;
			FingerList fingers = frame.Fingers;
			Fs = fingers.Count;
			
			o = frame.Fingers.FingerType(0).Count;
		}
	}
}