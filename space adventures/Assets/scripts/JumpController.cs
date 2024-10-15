using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    public float gravity = 9.8f;
    public float jumpForce;
    private float _fallVelocity = 1;
    private CharacterController _CharacterController;
    void Start()
    {
        _CharacterController = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        _fallVelocity += gravity * Time.fixedDeltaTime;
        _CharacterController.Move(Vector3.down * _fallVelocity * Time.fixedDeltaTime);
        if (_CharacterController.isGrounded)
        {
            _fallVelocity = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _fallVelocity = -jumpForce;
        }
    }
}
