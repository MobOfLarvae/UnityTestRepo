using UnityEngine;
using System.Collections;

public class testScript : MonoBehaviour {
	
	public string bark;
	
	// Use this for initialization
	void Start () {
	
		bark = "HELLO GOOD SIR GOOD DAY TO YOU GOOD SIR";
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if( Input.GetButton("Jump") )
		{
			Debug.Log(bark);
		}
		
	}
}
