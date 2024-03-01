using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float healthPoints = 100;
    public RectTransform HealthStatus;
    private float _maxHealth;
    void Start()
    {
        _maxHealth = healthPoints;
        DrawHPBar();
    }

    void Update()
    {

    }
    public void DealDamage(float Damage)
    {
        healthPoints -= Damage;
        if (healthPoints <= 0)
        {
            Destroy(gameObject);
        }
        DrawHPBar();
    }
    private void DrawHPBar()
    {
        HealthStatus.anchorMax = new Vector2(healthPoints / _maxHealth, 0.84f);
    }
}

