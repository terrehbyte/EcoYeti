using UnityEngine;
using System.Collections;

public class YetiController : MonoBehaviour
{
    public float MoveSpeed = 5;

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
        if (other.gameObject.tag == "Skier")
        {
            Destroy(other.gameObject);
        }
    }
    #endregion
}