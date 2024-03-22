using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCaster : MonoBehaviour
{
    public GameObject BallPrefab;
    public Transform BallCastPoint;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            Instantiate(BallPrefab, BallCastPoint.transform.position, BallCastPoint.transform.rotation);
        }

    }
}
