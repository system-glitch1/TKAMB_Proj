using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private Rigidbody2D  _Rigidbody;
    private Vector2 _movementInput;

    private void Awake()
    {
        _Rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _Rigidbody.velocity = _movementInput * _speed;
    }

    private void OnMove(InputValue inputValue)
    {
        _movementInput = inputValue.Get<Vector2>();
    }
}
