using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public float moveSpeed = 1f;
   private Rigidbody _rb;

    private void Start()
    {
        _rb = transform.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        _rb.MovePosition(transform.position + new Vector3(hInput * moveSpeed * Time.fixedDeltaTime, 0, vInput * moveSpeed * Time.fixedDeltaTime));
    }
}

