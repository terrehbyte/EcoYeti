using UnityEngine;
using System.Collections;

public class SkierObstacle : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Skier")
        {
            var SkiControl = GetComponent<BaseSkierController>();

            // Call death on the skier
            if (SkiControl)
            {
                SkiControl.Die(BaseSkierController.DeathReason.OBSTACLE);
            }
        }
    }
}
