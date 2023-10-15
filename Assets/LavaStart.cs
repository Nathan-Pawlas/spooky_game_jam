using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaStart : MonoBehaviour
{
    public GameObject lava;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            lava.SetActive(true);
        }
    }
}
