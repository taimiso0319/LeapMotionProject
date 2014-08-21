using UnityEngine;
using System.Collections;

public class ScreenPositionTest : MonoBehaviour {

	public GameObject mainCamera;

	public float x;
	public float y;
	public Vector3 v3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		v3 = mainCamera.camera.ScreenToWorldPoint(new Vector3(Screen.width/3,Screen.height/3,0));
	
	}
}
