using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCaster : MonoBehaviour
{
    public GameObject BallPrefab;
    public Transform BallCastPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            Instantiate(BallPrefab, BallCastPoint.transform.position, BallCastPoint.transform.rotation);
        } 
    }
}
