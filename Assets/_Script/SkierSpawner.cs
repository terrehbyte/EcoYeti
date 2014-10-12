using UnityEngine;
using System.Collections;

public class SkierSpawner : MonoBehaviour {

	public GameObject BasicSkier;
	public GameObject FastSkier;
	public GameObject BadSkier;
	public GameObject MomSkier;
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
	public int WaveCounter = 1;
	public bool FastEnabled = false;
	public bool BadEnabled = false;
	public bool MotherEnabled = false;


	// Use this for initialization
	void Start () {
		Debug.Log ("Started at all");
		WaveManager ();
	}

	void WaveManager ()
	{

		Debug.Log ("WaveManager Loaded");
			 //Decide if new things spawn yet;
			StartCoroutine (SpawnWaves ());
			WaveCounter++;
	}

		void SpawnDecider()
		{

			Debug.Log("SpawnDecider Loaded");
			int SpawnChance; //Chance for Fast
			SpawnChance = WaveCounter * 5;
			if (Random.Range (0, 100) <= SpawnChance) {
				FastEnabled = true;
			}
			SpawnChance = WaveCounter * 4; // Chance for Bad
			if (Random.Range (0, 100) <= SpawnChance) {
				BadEnabled = true;
			}
			SpawnChance = WaveCounter * 3; // Chance for Mother
			if (Random.Range (0,100) <= SpawnChance){
				MotherEnabled = true;
			}

		Debug.Log ("Mother is :" + MotherEnabled);
		Debug.Log ("Bad is :" + BadEnabled);
		Debug.Log ("Mother is :" + FastEnabled);
		}


	
	// Update is called once per frame
	IEnumerator SpawnWaves () {

		int RandomPick = 1;
		int SpawnLimit;
		GameObject SkiertoSpawn;


		yield return new WaitForSeconds (startWait);

		while (true) 
		{
			SpawnDecider ();
			
			if (MotherEnabled == true)
				SpawnLimit = 4;
			else if (BadEnabled == true)
				SpawnLimit = 3;
			else if (FastEnabled == true)
				SpawnLimit = 2;
			else
				SpawnLimit = 1;
			
			Debug.Log("Spawn Limit is" + SpawnLimit);

			for (int i = 0; i < hazardCount; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				RandomPick = Random.Range (1, SpawnLimit + 1);
				if (RandomPick == 1)
					SkiertoSpawn = BasicSkier;
				else if (RandomPick == 2)
					SkiertoSpawn = FastSkier;
				else if (RandomPick == 3)
					SkiertoSpawn = BadSkier;
				else
					SkiertoSpawn = MomSkier;
				Quaternion SpawnRotation = new Quaternion ();
				Instantiate (SkiertoSpawn, spawnPosition, SpawnRotation);
				yield return new WaitForSeconds (spawnWait);
				}
			WaveCounter++;
			yield return new WaitForSeconds (waveWait);
		}
	}
}
