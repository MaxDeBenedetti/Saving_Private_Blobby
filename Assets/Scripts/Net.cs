using UnityEngine;
using System.Collections;


public class Net : MonoBehaviour {
	
	public NetBreaker player;
	public GameObject[] holeLocations;
	public GameObject[] holes;
	public Animation approach ;
	public Animation exit;
	public float timeLimit = 4;
	private float deathTime;
	public TextMesh postuMessage;
	private int broken = 0;
	
	// Use this for initialization
	void Start () {
	 	makeNet();

	}
	
	// Update is called once per frame
	void Update () {

		if(Time.time>deathTime){
			lose ();	
		}
		
	}
	
	public void Break (){
		makeNet();
		broken++;
	}
	
	public void makeNet(){
		approach.Play();
		int nextHole = (int)(Random.value * holeLocations.Length);
		for(int i = 0; i < holes.Length; i++){
			holes[i].transform.position = holeLocations[nextHole].transform.position;
			nextHole = (int)(Random.value * holeLocations.Length);
		}
		
		deathTime = Time.time + timeLimit;
	}
	
	public void lose(){
		string str = "You broke " +broken+" nets.\nIf you donate today\nyou could break them all!\nPress esc to return to title";
		postuMessage.text = str;
		exit.Play();
	}
}
