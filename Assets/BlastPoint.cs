using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponentInParent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.GetComponentInParent<Rigidbody>().AddForce(new Vector3(0, 40f, 0), ForceMode.Impulse);
        }
    }
}
