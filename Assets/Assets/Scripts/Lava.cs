using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaLogic : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }
    int wait = 0;
    bool rising = false;
    // Update is called once per frame
    void Update()
    {
        wait += 1;
        if (wait == 450)
        {
            rising = true;

        }
        if (rising == true)
        {
            transform.position += new Vector3(0, .01f, 0);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        rising = false;
    }
    private void OnCollisionExit(Collision collision)
    {
        rising = true;
    }
}