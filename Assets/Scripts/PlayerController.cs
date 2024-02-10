using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float _fallVelocity = 0;
    public float Gravity = 9.8f;
    private CharacterController _characterController;
    public float JumpForce = 4;
    public float Speed;
    private Vector3 _moveVector;
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _characterController.Move(_moveVector * Speed * Time.fixedDeltaTime);
        _fallVelocity += Gravity * Time.fixedDeltaTime;
        _characterController.Move(Vector3.down * _fallVelocity * Time.fixedDeltaTime);
        if (_characterController.isGrounded)
        {
            _fallVelocity = 0;
        }
    }
    void Update()
    {

        _moveVector = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            _moveVector += transform.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _moveVector += transform.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _moveVector -= transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            _moveVector -= transform.right;
        }
        if (Input.GetKeyDown(KeyCode.Space) && _characterController.isGrounded)
        {
            _fallVelocity = -JumpForce;
            Debug.Log("jump");
        }
    }
}
