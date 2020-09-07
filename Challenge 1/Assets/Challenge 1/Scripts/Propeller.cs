/*
 * (Luke Alcazar)
 * (Challenge 1)
 * (This makes the planes propeller move... thats it)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    public float rotationspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, rotationspeed);
    }
}
