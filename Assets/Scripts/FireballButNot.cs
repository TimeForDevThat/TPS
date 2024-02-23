using UnityEngine;

public class FireballButNot : MonoBehaviour
{
    public float Speed;
    public float Lifetime = 3f; //It gives absolutely no attention to "= 3f". I tried
    void Start()
    {
        Invoke("BallDestruct", Lifetime);  
    }

    void FixedUpdate()
    {
        transform.position += transform.forward * Speed * Time.fixedDeltaTime;
    }
    void OnCollisionEnter()
    {
        BallDestruct();
    }
    void BallDestruct()
    {
        Destroy(gameObject);
    }
}
