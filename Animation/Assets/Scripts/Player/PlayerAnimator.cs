using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private string _speedTreshold = "speedTreshold";
    private string _triggerHit = "hit";
    private Player _player;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _player = GetComponent<Player>();
    }

    public void Expectation()
    {
        _animator.SetFloat(_speedTreshold, _player.GetSpeed());
    }

    public void Run()
    {
        _animator.SetFloat(_speedTreshold, _player.GetSpeed());
    }

    public void Hit()
    {
        _animator.SetTrigger(_triggerHit);
    }
}
