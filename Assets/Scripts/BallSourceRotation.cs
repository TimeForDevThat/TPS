using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSourceRotation : MonoBehaviour
{
    public Transform AimPoint;
    public Camera CameraLink;
    public float SkyPointDistance;
    void Start()
    {
        
    }

    void Update()
    {
        var ray = CameraLink.ViewportPointToRay(new Vector3(0.5f, 0.7f, 0));

        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            AimPoint.position = hit.point;
        }
        else
        {
            AimPoint.position = ray.GetPoint(SkyPointDistance);
        }
        transform.LookAt(AimPoint.position);  
    }
}
