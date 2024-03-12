using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meds : MonoBehaviour
{
    public float HPToHeal = 50;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        var PlayerHealth = other.GetComponent<PlayerHealth>();
        if(PlayerHealth != null)
        {
          PlayerHealth.AddHP(HPToHeal);
            Destroy(gameObject);
        }  
    }

}
