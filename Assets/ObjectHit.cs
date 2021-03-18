using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        // Signal when cubey hits the wall
        Debug.Log("Bumped into a wall");
        GetComponent<MeshRenderer>().material.color = Color.black;
    }
}
