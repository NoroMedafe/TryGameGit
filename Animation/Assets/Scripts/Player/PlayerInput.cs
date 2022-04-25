using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
   
    private SpriteRenderer _spriteRenderer;
    private Movement _mover;
    private PlayerAnimator _animator;
    private float _playerSpeed;

    private void Start()
    {
        _mover = GetComponent<Movement>();
        _animator = GetComponent<PlayerAnimator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
       _playerSpeed =_animator.CurrentPlayerSpeed();

        if (Input.GetKey(KeyCode.D))
        {
            _mover.VectorMovement(_speed);
            _spriteRenderer.flipX = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            _mover.VectorMovement(-_speed);
            _spriteRenderer.flipX = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
                _mover.JumpMove(_jumpForce);
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            _animator.hitTrigger();
        }

        if (_playerSpeed == 0)
            _animator.WaitingState();
        else
            _animator.RunState();
      
    }
}
