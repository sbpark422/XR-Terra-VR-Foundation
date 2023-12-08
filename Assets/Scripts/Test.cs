using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Transform followTransform;
    public Transform targetTransform;
    public float size = 0.5f;
    public float valueOutMin, valueOutMax, valueOut;

    void Start()
    {
        followTransform.parent = transform;
    }

    void Update()
    {
        DoFollow();
        //CalcValue();
    }

    public void DoFollow()
    {
        followTransform.position = targetTransform.position;
        // float xPos = Mathf.Clamp(followTransform.localPosition.x, 0, size);
        float xPos =followTransform.localPosition.x;
        followTransform.localPosition = new Vector3(xPos, 0, 0);
    }

    public void SnapTargetToFollow()
    {
        targetTransform.position = followTransform.position;
        targetTransform.rotation = followTransform.rotation;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.TransformPoint(new Vector3(size, 0, 0)));
    }

    void CalcValue()
    {
        float between0And1 = Mathf.InverseLerp(0, size, followTransform.localPosition.x);
        valueOut = Mathf.Lerp(valueOutMin, valueOutMax, between0And1);
    }
}
