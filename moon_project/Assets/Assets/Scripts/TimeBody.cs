using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBody : MonoBehaviour {

	bool isRewinding = false;

	public float recordTime = 50f;

	List<PointInTime> pointsInTime;

	//Rigidbody rb;

	// Use this for initialization
	void Start () {
		pointsInTime = new List<PointInTime>();
		//rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow))
			StartRewind();
		if (Input.GetKeyUp (KeyCode.LeftArrow))
			StopRewind();
	}

	void FixedUpdate ()
	{
		if (isRewinding)
			Rewind();
		else
			Record();
	}

	void Rewind ()
	{
		if (pointsInTime.Count > 0)
		{
			PointInTime pointInTime = pointsInTime[0];
			transform.position = pointInTime.position;
			transform.rotation = pointInTime.rotation;
			pointsInTime.RemoveAt(0);
		} else
		{
			StopRewind();
		}

	}

	void Record ()
	{
		if (pointsInTime.Count > Mathf.Round(recordTime / Time.fixedDeltaTime))
		{
			pointsInTime.RemoveAt(pointsInTime.Count - 1);
		}

		pointsInTime.Insert(0, new PointInTime(transform.position, transform.rotation));
	}

	public void StartRewind ()
	{
		Time.timeScale = 1.0F;
		isRewinding = true;
		//rb.isKinematic = true;
	}

	public void StopRewind ()
	{
		Time.timeScale = 0F;
		isRewinding = false;
		//rb.isKinematic = false;
	}
}