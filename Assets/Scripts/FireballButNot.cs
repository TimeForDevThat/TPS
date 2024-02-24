using UnityEngine;

public class FireballButNot : MonoBehaviour
{
    public float Speed;
    public float Lifetime = 3f; //It gives absolutely no attention to "= 3f". I tried
    public float damage = 10; //It works in prefabs wth?
    void Start()
    {
        Invoke("BallDestruct", Lifetime);  
    }

    void FixedUpdate()
    {
        transform.position += transform.forward * Speed * Time.fixedDeltaTime;
    }
    void OnCollisionEnter(Collision collision)
    {
        var enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemyHealth != null )
        {
            enemyHealth.healthPoints -= damage;
        }
        
        BallDestruct();
    }
    void BallDestruct()
    {
        Destroy(gameObject);
    }
}
