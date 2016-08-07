using UnityEngine;
using System.Collections;

public class grgr : MonoBehaviour {
	public float rotateX = 0.0f,
		rotateY = 1.0f,
		rotateZ = 0.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (rotateX, rotateY, rotateZ);
	}
}
