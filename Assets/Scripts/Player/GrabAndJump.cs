﻿using UnityEngine;
using System.Collections;

public class GrabAndJump : Jump {

	public bool hanging = false;
    public Movement movement;
    private GameObject obj;//hier ff doen voor de cube

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        movement = GetComponent<Movement>();
        rb.gravityScale = 2.5f;
    }        

    void Update()
    {
        if (hanging)
        {
			movement.enabled = false;
			rb.velocity = Vector3.zero;
			rb.gravityScale = 0;

            anim.SetBool("isSwinging", true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jumped();
                hanging = false;
                rb.gravityScale = 2.5f;
				movement.enabled = true;
                anim.SetBool("isSwinging", false);
                anim.SetBool("isJumping", true);
            }
        }
    }
}