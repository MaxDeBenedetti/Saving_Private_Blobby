using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKey){
			if(Input.GetKey("escape")){
				Application.Quit();
			}
			else
				Application.LoadLevel("main");	
		}
	}
}
