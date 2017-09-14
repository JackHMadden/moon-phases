using UnityEngine;
using System.Collections;

public class pausetime : MonoBehaviour {
	void Update() {
		if (Input.GetKeyUp(KeyCode.RightArrow) | Input.GetKeyDown(KeyCode.DownArrow))
			Time.timeScale = 0F;
		if (Input.GetKeyDown(KeyCode.RightArrow))
			Time.timeScale = 1.0F;
		}
}