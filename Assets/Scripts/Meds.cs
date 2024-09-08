using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meds : MonoBehaviour
{
    public float HPToHeal = 50;
    public GameObject PhysicCollider;
    public GameObject Player;
    void Start()
    {

    }

    void Update()
    {
        //PhysCheck();
    }
    private void OnTriggerEnter(Collider other)
    {
        var PlayerHealthPoints = other.GetComponent<PlayerHealth>().healthPoints;
        var PlayerHealthComp = other.GetComponent<PlayerHealth>();
        if(PlayerHealthComp != null && PlayerHealthPoints < 100)
        {
            PlayerHealthComp.AddHP(HPToHeal);
            Destroy(gameObject);
        }  
    }
    void PhysCheck()
    {
        var PlayerHealthPoints = Player.GetComponent<PlayerHealth>().healthPoints;
        if (PlayerHealthPoints < 100)
        {
            Destroy(PhysicCollider);
        }
    }

}
