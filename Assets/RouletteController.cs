using UnityEngine;
using System.Collections;

public class RouletteController : MonoBehaviour {

	float rotSpeed = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			this.rotSpeed = 10f;
		}

		transform.Rotate(0, 0, this.rotSpeed);

		rotSpeed *= 0.96f;
	}
}
