using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _maxDistanceJump;
    [SerializeField] private LayerMask _layerMask;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Move(float speed)
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    public void Jump(float jumpForce)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down,_maxDistanceJump,_layerMask);
        Debug.DrawRay(transform.position, Vector2.down * _maxDistanceJump, Color.red);
    
        if (hit)
        {
            _rigidbody2D.AddForce(Vector2.up * jumpForce);
        }

    }
}
