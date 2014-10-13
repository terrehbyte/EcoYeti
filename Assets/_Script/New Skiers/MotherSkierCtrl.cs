using UnityEngine;
using System.Collections;

public class MotherSkierCtrl : BaseSkierCtrl
{
    public int ChildrenCharges;
    public int ChanceOfSpawn;
    public int ChildrenPerSpawn;

    public GameObject ChildSkierPrefab;

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
            var CurrentPosition = rigidbody.transform.position;
            Quaternion SpawnRotation = new Quaternion();

            if (ChildrenCharges > 0)
            {
                int Pregrate = Random.Range(0, 100);
                if (Pregrate <= ChanceOfSpawn)
                {
                    for (int i = 0; i < ChildrenPerSpawn; i++)
                    {
                        Instantiate(ChildSkierPrefab, CurrentPosition, SpawnRotation);

                        ChildrenCharges--;
                    }
                }
            }
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
