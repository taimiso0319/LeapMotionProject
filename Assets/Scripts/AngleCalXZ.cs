using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AngleCalXZ : MonoBehaviour {

	public GameObject handPos;
	public GameObject stdPosObject;
	public GameObject finDistXObject;
	public GameObject uiText;

	public float initZLength;
	public float fingerAngle;
	public float stdPos;

	public string angleStr;

	public Vector3 lengthVec;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		lengthVec = new Vector3(Mathf.Abs(handPos.transform.position.x - this.transform.position.x),
		                        0,
		                        Mathf.Abs(handPos.transform.position.z - this.transform.position.z));

		fingerAngle = Mathf.Atan2(lengthVec.x,lengthVec.z) * Mathf.Rad2Deg;
	
		stdPosObject.transform.position = new Vector3(handPos.transform.position.x,
		                                              handPos.transform.position.y,
		                                              transform.position.z);

		finDistXObject.transform.position = new Vector3(transform.position.x,
		                                                handPos.transform.position.y,
		                                                handPos.transform.position.z);
		if(this.transform.position.x >= handPos.transform.position.x)angleStr = fingerAngle.ToString("F1");
		else angleStr = "-" + fingerAngle.ToString("F1");
		uiText.GetComponent<Text>().text = angleStr + "°";
	}
}
