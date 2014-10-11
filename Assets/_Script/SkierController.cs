using UnityEngine;
using System.Collections;

public class SkierController : MonoBehaviour {

	public GameObject skier;
	
	// Update is called once per frame
	void LateUpdate () {
	
		transform.position = skier.transform.position;

	}
}