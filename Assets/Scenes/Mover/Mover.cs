using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public float maxSpeed = 1f;
    private Transform thisTransform = null;

    private void Awake()
    {
        thisTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        // deltatime makes the moving not dependent of the computer's framerate
        thisTransform.position += thisTransform.forward * maxSpeed * Time.deltaTime;
    }

}
