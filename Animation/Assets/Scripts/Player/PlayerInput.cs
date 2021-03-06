using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
[RequireComponent(typeof(Movement))]
[RequireComponent(typeof(PlayerAnimator))]
[RequireComponent(typeof(SpriteRenderer))]

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
   
    private SpriteRenderer _spriteRenderer;
    private Movement _mover;
    private PlayerAnimator _animator;
    private float _playerSpeed;
    private Player _player;

    private void Start()
    {
        _mover = GetComponent<Movement>();
        _animator = GetComponent<PlayerAnimator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _player = GetComponent<Player>();
    }

    private void Update()
    {
       _playerSpeed =_player.GetSpeed();

        if (Input.GetKey(KeyCode.D))
        {
            _mover.Move(_speed);
            _spriteRenderer.flipX = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            _mover.Move(-_speed);
            _spriteRenderer.flipX = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _mover.Jump(_jumpForce);
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            _animator.Hit();
        }

        if (_playerSpeed == 0)
            _animator.Expectation();
        else
            _animator.Run();
      
    }
}
