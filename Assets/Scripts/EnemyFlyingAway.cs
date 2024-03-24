using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlyingAway : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Disappear", 20); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * 2 * Time.deltaTime;
    }
    void Disappear()
    {
        Destroy(gameObject);
    }
}
