using UnityEngine;
using System.Collections;

public class AngleCal : MonoBehaviour {

	public float Xlength, Ylength, Zlength;
	public float Angle;
	public string DisplayStr;

	public GameObject HandPos;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Xlength = Mathf.Abs(transform.position.x - HandPos.transform.position.x);
		Ylength = Mathf.Abs(transform.position.y - HandPos.transform.position.y);
		Zlength = Mathf.Abs(transform.position.z - HandPos.transform.position.z);

		Angle = Mathf.Atan2(Mathf.Sqrt(pow(Xlength,2)+pow(Zlength,2)),Ylength) * Mathf.Rad2Deg;
	}

	public float pow(float length,int num){

		float ans = length;

		for(int i = 0; i < num - 1; i++){
			ans = ans * length;
		}

		return ans;
	}

}
