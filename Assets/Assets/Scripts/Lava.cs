using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaLogic : MonoBehaviour
{
    private GameManager gm;

    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        transform.position = new Vector3(0, -1, 0);
    }

    bool rising = true;
    void Update()
    {
        if (rising == true)
        {
            transform.position += new Vector3(0, .01f, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gm.setDead();
            rising = false;
        }
    }
}