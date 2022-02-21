using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Vector3 _direction = Vector3.right;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _direction = Vector2.up;
        } else if (Input.GetKeyDown(KeyCode.S))
        {
            _direction = Vector2.down;
        } else if (Input.GetKeyDown(KeyCode.A))
        {
            _direction = Vector2.left;
        }else if (Input.GetKeyDown(KeyCode.D))
        {
            _direction = Vector2.right;
        }
    }

    private void FixedUpdate()
    {
        this.transform.position = new Vector3(
            Mathf.Round(this.transform.x) + _direction.x,
            Mathf.Round(this.transform.y) + _direction.y,
            0.0f
        );
    }
}
