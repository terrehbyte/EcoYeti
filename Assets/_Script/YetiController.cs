using UnityEngine;
using System.Collections;

public class YetiController : MonoBehaviour
{
    public float MoveSpeed = 5;
	public GameObject SoundKidScream;
	public GameObject SoundMomScream;
	public GameObject SoundMaleScream1;
	public GameObject SoundMaleScream2;
	public GameObject SoundMaleScream3;
	public GameObject SoundMaleScream4;
	public GameObject SoundDestructable;
	public GameObject SoundTree;

    [SerializeField]
    private float rayLength = 10;
    [SerializeField]
    private float MoveTowardsDelta = 0.1f;

    Vector3 AcceptInput()
    {
        Vector3 input = Vector3.zero;

        input.x = Input.GetAxis("Horizontal");
        input.z = Input.GetAxis("Vertical");

        return input;
    }

    void keepToGround()
    {
        Ray downRay = new Ray(transform.position, -Vector3.up * rayLength);
        RaycastHit[] hitInfo = Physics.RaycastAll(downRay, rayLength);
        Vector3 target = Vector3.zero;
        float distance = 0f;

        for (int i = 0; i < hitInfo.Length; i++)
        {
            if (hitInfo[i].collider != collider)
            {
                target = hitInfo[i].point;
                distance = hitInfo[i].distance;
                break;
            }
        }

        if (target != Vector3.zero && distance != 0f)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, MoveTowardsDelta);
        }
    }

    #region Unity Events

    void FixedUpdate()
    {
        Vector3 input = AcceptInput();
        Vector3 newVel = Vector3.zero;

        newVel.x = input.x * MoveSpeed;
        newVel.y = rigidbody.velocity.y;
        newVel.z = input.z * MoveSpeed;

        rigidbody.velocity = newVel;
        
        keepToGround();

        rigidbody.AddForce(Physics.gravity, ForceMode.Acceleration);

        // Rie Tanaka
        // Kugimiya Rie
        // Aoi Yuki
        // Kana Hanazawa
        // Eri Kitamuri
        // Yu Asakawa
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Skier") {
						Destroy (other.gameObject);
						if (other.gameObject.name == "ChildSkierBall(Clone)") {
								Quaternion SpawnRotation = new Quaternion ();
								Vector3 SpawnLocation = new Vector3 (0, 0, 0);
								Instantiate (SoundKidScream, SpawnLocation, SpawnRotation);
						} else if (other.gameObject.name == "MotherSkierBall(Clone)") {
								Quaternion SpawnRotation = new Quaternion ();
								Vector3 SpawnLocation = new Vector3 (0, 0, 0);
								Instantiate (SoundMomScream, SpawnLocation, SpawnRotation);
						} else {
								int RandomScream = Random.Range (1, 5);
								if (RandomScream == 1) {
										Quaternion SpawnRotation = new Quaternion ();
										Vector3 SpawnLocation = new Vector3 (0, 0, 0);
										Instantiate (SoundMaleScream1, SpawnLocation, SpawnRotation);
								} else if (RandomScream == 2) {
										Quaternion SpawnRotation = new Quaternion ();
										Vector3 SpawnLocation = new Vector3 (0, 0, 0);
										Instantiate (SoundMaleScream2, SpawnLocation, SpawnRotation);
								} else if (RandomScream == 3) {
										Quaternion SpawnRotation = new Quaternion ();
										Vector3 SpawnLocation = new Vector3 (0, 0, 0);
										Instantiate (SoundMaleScream3, SpawnLocation, SpawnRotation);
								} else {
										Quaternion SpawnRotation = new Quaternion ();
										Vector3 SpawnLocation = new Vector3 (0, 0, 0);
										Instantiate (SoundMaleScream4, SpawnLocation, SpawnRotation);
								}
						}
				} else if (other.gameObject.tag == "Destructable") {
						Destroy (other.gameObject);
						Quaternion SpawnRotation = new Quaternion ();
						Vector3 SpawnLocation = new Vector3 (0, 0, 0);
						Instantiate (SoundDestructable, SpawnLocation, SpawnRotation);
				} 
    }
    #endregion
}