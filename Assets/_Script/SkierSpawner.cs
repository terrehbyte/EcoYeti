using UnityEngine;
using System.Collections;

public class SkierSpawner : MonoBehaviour {

	public GameObject BasicSkier;
	public GameObject BasicSkierMask;
	public Vector3 spawnValues;
	public GameObject SkierSpawner1;
	public GameObject SkierSpawner2;
	public GameObject SkierSpawner3;
	public GameObject SkierSpawner4;
	public GameObject SkierSpawner5;
	public GameObject SkierSpawner6;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public float decreaseWaveWait;
	public int incrimentHazard;

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnWaves ());
	}
	
	// Update is called once per frame
	IEnumerator SpawnWaves () {

		yield return new WaitForSeconds (startWait);
		while(true)
		{
			waveWait = waveWait - decreaseWaveWait;
			if (waveWait < 1)
			{
				waveWait = 1;
			}

			for (int i = 0; i < hazardCount; i++) 
			{
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion SpawnRotation = new Quaternion ();
				Instantiate (BasicSkier, spawnPosition, SpawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}

			hazardCount = hazardCount + incrimentHazard;
			yield return new WaitForSeconds (waveWait);
		}
	}
}
