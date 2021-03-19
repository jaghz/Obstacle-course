using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer objectRenderer; //caching a reference: storing frequently used data/information in memory, so that it can be easily accessed when needed
    Rigidbody dropperBody;
    [SerializeField] float timeToWait = 2f;
    // Start is called before the first frame update
    void Start()
    {
        objectRenderer = GetComponent<MeshRenderer>();
        objectRenderer.enabled = false;

        dropperBody = GetComponent<Rigidbody>();
        dropperBody.useGravity = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait) //Time.time prints how much time has elapsed
        {
            objectRenderer.enabled = true;
            dropperBody.useGravity = true;
        }
    }
}
