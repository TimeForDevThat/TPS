using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeCaster : MonoBehaviour
{
    public Rigidbody GrenadePrefab;
    public Transform GrenadeThrowPoint;
    public float ThrowForce;
    void Start()
    {
        
    }

    void Update()
    {
        GrenadeThrow();
    }
    void GrenadeThrow()
    {
        if (Input.GetMouseButtonDown(1))
        {
            var grenadeInst = Instantiate(GrenadePrefab);
            grenadeInst.transform.position = GrenadeThrowPoint.position;
            grenadeInst.GetComponent<Rigidbody>().AddForce(GrenadeThrowPoint.forward * ThrowForce);
        }
    }
}
