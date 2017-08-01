using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
	
	public float speed = 10;

    private Rigidbody rb;
	
	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = Vector3.up * Input.GetAxis("Vertical") * speed + Vector3.right * Input.GetAxis("Horizontal") * speed;
		
	}
	
	
	
}
