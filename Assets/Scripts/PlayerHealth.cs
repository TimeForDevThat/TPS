using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static float healthPoints = 100;
    public RectTransform HealthStatus;
    private float _maxHealth;
    public GameObject InGamePlayUI;
    public GameObject GameOverUI;
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
            GameOverUI.SetActive(true);
            InGamePlayUI.SetActive(false);
            GetComponent<PlayerController>().enabled = false;
            GetComponent<BallCaster>().enabled = false;
            GetComponent<CamRotation>().enabled = false;
        }
        DrawHPBar();
    }
    private void DrawHPBar()
    {
        HealthStatus.anchorMax = new Vector2(healthPoints / _maxHealth, 0.84f);
    }
    public void AddHP(float amount)
    {
        healthPoints += amount;
        healthPoints = Mathf.Clamp(healthPoints, 0, _maxHealth);
        DrawHPBar();
    }
}

