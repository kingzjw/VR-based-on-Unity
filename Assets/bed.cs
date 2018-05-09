using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bed : MonoBehaviour {
    public float bounceForce = 1000f;

    void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(Vector3.up * bounceForce);
        }
    }
}
