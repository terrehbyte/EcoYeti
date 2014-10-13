using UnityEngine;
using System.Collections;

public class BadSkierCtrl : BaseSkierCtrl
{
    public float XVariance;
    public float SpeedModifier;

    #region Functions
    protected override void Ski()
    {
        base.Ski();
    }

    protected override void ProcTriggerZone(Collider other)
    {
        base.ProcTriggerZone(other);
        if (other.gameObject.tag == "TriggerZone")
        {
            Debug.Log("switch! :)");
            Vector3 movement = new Vector3(Random.Range(-XVariance, XVariance), 0.0f, 0.0f);
            Vector3 forceVector = movement * SpeedModifier;
            Debug.Log("Force!" + forceVector);
            rigidbody.AddForce(forceVector);
        }	
    }

    public override void Die(BaseSkierCtrl.DeathReason reason)
    {
        base.Die(reason);
    }
    #endregion
    #region Unity Events
    // Use this for initialization
    override protected void Start()
    {

    }

    // Update is called once per frame
    override protected void Update()
    {

    }
    #endregion
}
