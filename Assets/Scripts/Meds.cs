using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meds : MonoBehaviour
{
    public float HPToHeal = 50;
    public GameObject PhysicCollider;
    void Start()
    {

    }

    void Update()
    {
        PhysCheck();
    }
    private void OnTriggerEnter(Collider other)
    {
        var PlayerHealth = other.GetComponent<PlayerHealth>();
        if(PlayerHealth != null && PlayerHealth.healthPoints < 100)
        {
            PlayerHealth.AddHP(HPToHeal);
            Destroy(gameObject);
        }  
    }
    void PhysCheck()
    {
        if (PlayerHealth.healthPoints < 100)
        {
            Destroy(PhysicCollider);
        }
    }

}
