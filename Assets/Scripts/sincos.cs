using UnityEngine;
using System.Collections;

public class sincos : MonoBehaviour {

	//public float radius = 5.0f;
	public float speed = 5.0f;
	//private float counter = 0;
	private float rotate = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.D)){
			rotate+=speed;
			//counter++;
			//transform.position = new Vector3(Mathf.Sin(counter * speed) * radius,0,Mathf.Cos (counter * speed) * radius);
		}else if(Input.GetKey(KeyCode.A)){
			rotate-=speed;
			//counter++;
			//transform.position = new Vector3(Mathf.Sin(counter * -speed) * radius,0,Mathf.Cos (counter * -speed) * radius);
		}
		transform.rotation = Quaternion.Euler(0,rotate,0);
	}
}
