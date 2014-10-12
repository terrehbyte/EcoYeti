using UnityEngine;
using System.Collections;

public class MotherSkierController : MonoBehaviour {
	
	public int ChildrenCharges;
	public int ChanceOfSpawn;
	public Vector3 CurrentPosition;
	public GameObject SkierSpawn;
	public int ChildrenPerSpawn;
	
	
	void OnTriggerEnter (Collider other) 
	{
		if (other.gameObject.tag == "TriggerZone") 
		{
			CurrentPosition = rigidbody.transform.position;
			Quaternion SpawnRotation = new Quaternion();

				if (ChildrenCharges > 0)
			{
				int Pregrate = Random.Range (0, 100);
				if (Pregrate <= ChanceOfSpawn)
				{


					for(int i = 0; i < ChildrenPerSpawn; i++){
						Instantiate (SkierSpawn, CurrentPosition, SpawnRotation);

				ChildrenCharges--;
					}
				}
			}
		}	
	} 
	
}

