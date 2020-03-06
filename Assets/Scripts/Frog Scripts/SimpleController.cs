﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//simple controller conttrols direction character moves, change to up or left with taps

public class SimpleController : MonoBehaviour
{
    public bool turn;
    public Rigidbody2D myRigidBody;
    public float movespeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (turn == true)
        {
            myRigidBody.velocity = new Vector2(0, movespeed);
        }

        if (turn == false)
        {
            myRigidBody.velocity = new Vector2(-movespeed, 0);
        }

        Vector3 moveDirection = gameObject.transform.position;
        if (moveDirection != Vector3.zero)
        {
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    public void turnfrog()
    {
        if (turn == true)
        {
            turn = false;
        }
        else if (turn == false)
        {
            turn = true;
        }
    }

}
