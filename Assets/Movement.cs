using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 1f;
    public Vector3 Direction1 = Vector3.forward;
    public Vector3 Direction2 = Vector3.left;
    private Rigidbody _rigidbody;
    private int _directionIndex;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();    
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_directionIndex == 0)
                _directionIndex = 1;
            else
                _directionIndex = 0;
        }
    }

    private Vector3 GetDirection()
    {
        if (_directionIndex == 0)
            return Direction1;
        return Direction2;
    }

    private void FixedUpdate()
    {
        Vector3 velocity = GetDirection() * Speed;
        velocity.y = _rigidbody.velocity.y;
        _rigidbody.velocity = velocity;
    }

    private void OnDisable()
    {
        Vector3 velocity = Vector3.zero;
        velocity.y = _rigidbody.velocity.y;
        _rigidbody.velocity = velocity;
    }
}
