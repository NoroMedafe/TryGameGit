using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private float _posX;
    private float speed;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _posX = transform.position.x;
    }

    public float CurrentPlayerSpeed()
    {
         speed = (transform.position.x - _posX) / Time.deltaTime;
        _posX = transform.position.x;
        return speed =Mathf.Abs(speed);
    }

    public void WaitingState()
    {
        _animator.SetFloat("aSpeed", speed);
    }

    public void RunState()
    {
        _animator.SetFloat("aSpeed", speed);
    }
    public void hitTrigger()
    {
        _animator.SetTrigger("hit");
    }
}
