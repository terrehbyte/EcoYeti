using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]   // requires rigidbody
public class FastSkierCtrl : BaseSkierCtrl
{
    public int MovementMultiplier;

    #region Functions
    protected override void Ski()
    {
        base.Ski();
        Vector3 movement = new Vector3(0.0f, 0.0f, -1.0f);
        rigidbody.AddForce(movement * MovementMultiplier);
    }

    protected override void ProcTriggerZone(Collider other)
    {
        base.ProcTriggerZone(other);
    }

    public override void Die(BaseSkierCtrl.DeathReason reason)
    {
        base.Die(reason);
    }
    #endregion
    #region Unity Events
    // Use this for initialization
	override protected void Start () {
	
	}
	
	// Update is called once per frame
	override protected void Update () {

    }
    #endregion
}
