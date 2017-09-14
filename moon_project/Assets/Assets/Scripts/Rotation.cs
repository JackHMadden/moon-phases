using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	public float speed;
	public Vector3 axis;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		transform.Rotate (axis * speed * Time.fixedDeltaTime, Space.World);
	}
}
