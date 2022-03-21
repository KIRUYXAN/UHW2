using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 _direction;
    private bool _sprint;
    public float speed = 2f;

    void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
        _sprint = Input.GetButton("Sprint");
    }

    void FixedUpdate()
    {
        Move(Time.fixedDeltaTime);

    }
    private void Move(float delta)
    {
        transform.position += _direction.normalized * (_sprint ? speed * 2 : speed) * delta;
    }
}