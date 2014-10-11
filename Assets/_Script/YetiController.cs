using UnityEngine;
using System.Collections;

public class YetiController : MonoBehaviour {

	public GameObject player;


	
	// Update is called once per frame
	void LateUpdate () {

		transform.position = player.transform.position;
	
	}


}
//Destroy (other.gameObject);