﻿using UnityEngine;
using System.Collections;

public class GrabAndJump : Jump {

	private bool hanging = false;
    private Movement movement;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        movement = GetComponent<Movement>();
        jumpPower = 0;
    }        

    void Update()
    {
        if (hanging)
        {
            anim.SetBool("isSwinging", true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jumped();
                hanging = false;
                rb.gravityScale = .5f;
				movement.enabled = true;
                anim.SetBool("isSwinging", false);
                anim.SetBool("isJumping", true);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("rocks"))
        {
            Debug.Log("klfea");
			movement.enabled = false;
            hanging = true;
            rb.velocity = Vector3.zero;
            rb.gravityScale =0;
        }
    }
}