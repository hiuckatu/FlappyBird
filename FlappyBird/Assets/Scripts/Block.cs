using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    Rigidbody2D _rigidbody;
    float _speed = -240f; // ˆÚ“®‘¬“x

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.AddForce(new Vector2(_speed, 0));
    }

    void Update()
    {
        Vector2 position = transform.position;
        if (position.x < GetLeft())
        {
            Destroy(gameObject);
        }
    }

    float GetLeft()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        return min.x;
    }
}
