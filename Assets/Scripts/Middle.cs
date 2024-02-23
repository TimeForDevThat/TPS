using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Middle : MonoBehaviour
{
    public Transform PointA;
    public Transform PointB;

    void Update()
    {
        MiddleTransform();   
    }
    private void MiddleTransform()
    {
        transform.position = Vector3.Lerp(PointA.position, PointB.position, 0.5f);
    }
}
