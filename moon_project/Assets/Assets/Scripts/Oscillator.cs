using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour {

	public float period;
	public float phase;
	public float Xamplitude;
	public float Yamplitude;
	public float Zamplitude;
	float t;


	// Use this for initialization
	void Start () {
		float period = 1;
		float phase = 0;
		float Xamplitude = 0;
		float Yamplitude = 1;
		float Zamplitude = 0;
		float t = 0;
}

	// Update is called once per frame
	void FixedUpdate () {
		t += Time.fixedDeltaTime;
		float x = transform.position.x + Mathf.Cos ((2 * Mathf.PI / period)*t+phase) *  Xamplitude;
		float y = transform.position.y + Mathf.Cos ((2 * Mathf.PI / period)*t+phase) *  Yamplitude;
		float z = transform.position.z + Mathf.Cos ((2 * Mathf.PI / period)*t+phase) *  Zamplitude;
		transform.position = new Vector3 (x, y, z);
	}
}
