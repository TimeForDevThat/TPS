using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    public float healthPoints = 100; //Still, gives no attention lul
    public GameObject DefeatObject;
    public GameObject Player;
    void Start()
    {

    }

    void Update()
    {

        if (healthPoints <= 0)
        {
            DefeatObject.transform.position = transform.position;
            Instantiate(DefeatObject);
            Destroy(gameObject);
        }
    }
    public void DealHimDamage(float Damage)
    {
        healthPoints -= Damage;
    }
}
