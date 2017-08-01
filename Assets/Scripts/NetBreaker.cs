using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class NetBreaker : MonoBehaviour {
	
	public Net net;
	public AudioClip thump;
	public int struggles = 0;
	public int thenBreak = 3;
	public bool inTheHole = false;
	public Animation breaking;

    private AudioSource audio;
	// Use this for initialization
	void Start () {
        audio = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space")){
			if(inTheHole ){
				audio.PlayOneShot(thump);
				if(struggles==thenBreak){
					breaking.Play();
					net.Break();
					struggles =0;
				}
				else{
					struggles++;

					
				}
			}
		}
	}
	
	void OnTriggerEnter(Collider other){
		inTheHole = true;
	}
	
	void OnTriggerExit(Collider other){
		inTheHole = false;
	}
	
}
