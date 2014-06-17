using UnityEngine;
using System.Collections;

public class AngleCal : MonoBehaviour {

	private float Xlength, Ylength, Zlength;
	public float Angle;
	public string DisplayStr;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public float pow(float length,int num){

		float ans = length;

		for(int i = 0; i < num - 1; i++){
			ans = ans * length;
		}

		return ans;
	}

}
