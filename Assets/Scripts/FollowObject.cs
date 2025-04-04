using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] bool keepRelativeOffset = false;

    Vector3 relativeOffset;
    Vector3 relativeRotation;

    private void Start()
    {
        if (keepRelativeOffset)
        {
            relativeOffset = target.InverseTransformPoint(transform.position);
            relativeRotation = 
            print(relativeOffset);
        }
    }

    private void LateUpdate()
    {
        if (keepRelativeOffset)
        {
            transform.rotation = target.rotation;
            transform.position = target.position + target.TransformPoint(relativeOffset);
        }
        else
        {
            transform.rotation = target.rotation;
            transform.position = target.position;
        }
    }
}
