using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1;
    [SerializeField] float boostSpeed = 40f;
    [SerializeField] float baseSpeed = 30f;

    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.W))
        {
            surfaceEffector2D.speed = boostSpeed;
        }

        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }


    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(torqueAmount);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
