using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class planetRotate : MonoBehaviour
{
    public float rotationSpeed;
    private CharacterController _controller;
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, 1, 0);
    }
}
