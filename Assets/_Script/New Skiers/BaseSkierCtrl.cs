using UnityEngine;
using System.Collections;

public class BaseSkierCtrl : MonoBehaviour
{
    public AudioSource SoundSource; // 
    public AudioClip DeathSound;
    public AudioClip TreeDeathSound;

    public enum DeathReason
    {
        YETI,
        OBSTACLE
    }

	// Use this for initialization
	virtual protected void Start ()
    {
        // Maybe play a spawning noise? "WOOHOO!"
	}
	
	// Update is called once per frame
	virtual protected void Update () {
	
	}

    virtual protected void ProcTriggerZone(Collider other)
    {

    }

    virtual protected void Ski()
    {

    }

    virtual protected void OnTriggerEnter(Collider other)
    {
        ProcTriggerZone(other);
    }

    virtual public void Die(DeathReason reason)
    {
        switch (reason)
        {
            case DeathReason.YETI:
                {
                    SoundSource.clip = DeathSound;
                    SoundSource.Play();
                    break;
                }
            case DeathReason.OBSTACLE:
                {
                    SoundSource.clip = TreeDeathSound;
                    SoundSource.Play();
                    break;
                }
            default:
                { 
                    Debug.LogWarning("Unknown reason for death!");
                    break;
                }
        }
    }
}
