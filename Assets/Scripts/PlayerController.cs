﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _fallVelocity = 0;
    public float Gravity = 9.8f;
    private CharacterController _characterController;
    public float JumpForce = 4;
    public float Speed;
    private Vector3 _moveVector;
    private Animator _animator;
    public GameObject PlayerModel;
    //public int GameTarget = 2; //unused, didnt work
    //public int WayToTarget; //unused, didnt work
    public GameObject GameFinishSpot;
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _animator = PlayerModel.GetComponent<Animator>();
    }

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
        _animator.SetBool("RunForward", false);
        _animator.SetBool("RunRight", false);
        _animator.SetBool("RunBackward", false);
        _animator.SetBool("RunLeft", false);
        if (Input.GetKey(KeyCode.W))
        {
            _moveVector += transform.forward;
            _animator.SetBool("RunForward", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _moveVector += transform.right;
            _animator.SetBool("RunRight", true);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _moveVector -= transform.forward;
            _animator.SetBool("RunBackward", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _moveVector -= transform.right;
            _animator.SetBool("RunLeft", true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && _characterController.isGrounded)
        {
            _fallVelocity = -JumpForce;
        }
    }
    void OnTriggerEnter(Collider finish)
        {
            var gameFinish = finish.GetComponent<GameFinish>();
            if (gameFinish != null)
            {
                gameFinish.GameFinishedUI();
                Destroy(gameObject);
            }
        }
    public void PlayerDel()
    {
        Destroy(gameObject);
    }

}
