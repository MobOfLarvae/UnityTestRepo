using UnityEngine;
using System.Collections;

public class PrefabSillyScript : MonoBehaviour {
	
	
	public float speed;
	public string bark;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetButton("Fire1"))
		{
			Debug.Log(bark);			
		}
		if(Input.GetButton("Fire2"))
		{
			Debug.Log ("speed " + speed);
		}
	}
}
