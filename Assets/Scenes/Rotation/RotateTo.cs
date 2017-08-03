using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTo : MonoBehaviour {

    private Transform thisTransform = null;
    public float rotSpeed = 90f;
    public Transform target;

    private void Awake()
    {
        thisTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        // Uses degrees to rotate around axis
        //thisTransform.rotation = Quaternion.Euler(0f, 90f, 0f);

        // Rotates object by rotSpeed around Y axis in global space
        // Quaternion.AngleAxis(rotSpeed * Time.deltaTime, Vector3.up);

        // Take existing rotation and add angleaxis to it
        //thisTransform.rotation *= Quaternion.AngleAxis(rotSpeed * Time.deltaTime, Vector3.up);

        //target.position - thisTransform.position gives us a difference between them
        //thisTransform.rotation = Quaternion.LookRotation(target.position - thisTransform.position, Vector3.up);

        Quaternion destRot = Quaternion.LookRotation(target.position - thisTransform.position, Vector3.up);
        thisTransform.rotation = Quaternion.RotateTowards(thisTransform.rotation, destRot, rotSpeed * Time.deltaTime);
    }

}
