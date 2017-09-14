using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {


	public GameObject centerofmass;
	public float speed;
	public Vector3 antinormal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.RotateAround (centerofmass.transform.position, antinormal, speed * Time.fixedDeltaTime);
	}
}
