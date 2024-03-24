using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XplosionControl : MonoBehaviour
{
    public float ScaleSpeed = 1;
    public float MaxSize = 4;
    public float XplosionDamage = 60;
    public float XplosionDamageToPlayer = 20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += Vector3.one * ScaleSpeed;
        SizeCheckDestroy();
    }
    void SizeCheckDestroy()
    {
        if(transform.localScale.y >= MaxSize)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        var PlayerHealth = other.GetComponent<PlayerHealth>();
        if(PlayerHealth != null)
        {
            PlayerHealth.DealDamage(XplosionDamageToPlayer);
        }
        var EnemyHealth = other.GetComponent<EnemyHealth>();
        if (EnemyHealth != null)
        {
            EnemyHealth.DealHimDamage(XplosionDamage);
        }
    }
}
