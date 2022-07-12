using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorScale : MonoBehaviour


{
    void Start()
    {
        // Sets the position to be somewhere inside a sphere
        // with radius 5 and the center at zero.

        transform.position = Random.insideUnitSphere * 5;
    }
}