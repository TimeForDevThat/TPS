using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float healthPoints = 100; //Still, gives no attention lul
    void Start()
    {
        
    }

    void Update()
    {
     if(healthPoints <= 0)
        {
            Destroy(gameObject);
        }   
    }
}
