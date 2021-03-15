using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // float xValue, yValue, zValue are stored in Update() bc they must read in the value every frame for object to move!
        //Time.deltaTime makes the movement frame rate independent
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed; // Are you pushing left or right (or a or d) on the keyboard?
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed; // Pushing up or down (or w or s) on the keyboard?

        transform.Translate(xValue,0,zValue); //Input.something allows us to access the Input Manager (Edit>Project Settings>Input Manager)
                                                                          //Which has predefined keys for horiz/vertical movements
        
    
    
    }                                                                           
}
