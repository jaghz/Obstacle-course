using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        // Signal when cubey hits the wall
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
}
