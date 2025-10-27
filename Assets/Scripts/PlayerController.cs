using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private Vector2 _sensorPosition;
    private Vector2 _sensorSize;

    private BoxCollider2D _boxCollider;
    [SerializeField] private float _playerSpeed = 3;
    [SerializeField] private float _jumpForce = 4;
    private Vector2 _moveInput;
    private InputAction _moveAction;
    private InputAction _jumpAction;

    void Awake()
    {
        _moveAction = InputSystem.actions["Move"];
        _jumpAction = InputSystem.actions["Jump"];
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
    void Start()
    {

    }


    void Update()
    {

        _moveInput = _moveAction.ReadValue<Vector2>();

        //Jump();



    }

    void FixedUpdate()
    {
        Move();
    }


    void Move()
    {
        if (_moveInput.x > 0)
        {
            _rigidbody.linearVelocity = new Vector2(_playerSpeed * _moveInput.x, _rigidbody.linearVelocityY);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            _animator.SetBool("IsRunning", true);
        }
        else if (_moveInput.x < 0)
        {
            _rigidbody.linearVelocity = new Vector2(_playerSpeed * _moveInput.x, _rigidbody.linearVelocityY);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            _animator.SetBool("IsRunning", true);
        }
        else
        {
            _animator.SetBool("IsRunning", false);
        }

    }

    /*void Jump()
    {
        if(_jumpAction.WasPressedThisFrame() && IsGrounded())
        {
            _rigidbody.AddForce(new Vector2 Mathf.Sqrt(_jumpForce * -2 * _rigidbody.linearVelocityY)) = ForceMode.Impulse;
            _rigidbody.AddForce = new Vector2.(transform.up, Mathf.Sqrt, (_jumpForce * -2, _rigidbody)).ForceMode.Impulse;
        }
        
    }

    bool IsGrounded()
    {
       Collider2D ground = Physics2D.OverlapBoxAll(_sensorPosition.position, _sensorSize, 3);
        foreach (grounds in ground)
        {
            if (ground.gameObtect.layer == 3)
            {
                IsGrounded = true;
            }

            
        }

       return; 
       
    }*/

    /*void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube = (_sensorPosition, 0 * _sensorSize, 0);
    }*/


}
