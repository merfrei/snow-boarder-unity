using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerController : MonoBehaviour
{
    [SerializeField] float TorqueAmount = 2f;
    [SerializeField] SurfaceEffector2D surface = null;
    [SerializeField] float speedVariation = 0.1f;

    [SerializeField] float minSpeed = 0;
    [SerializeField] float maxSpeed = 25;

    private Rigidbody2D body;

    void Start()
    {
        this.body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float speed;
        if (this.surface != null && Input.GetKey(KeyCode.DownArrow))
        {
            speed = this.surface.speed - this.speedVariation;
            this.surface.speed = speed > this.minSpeed ? speed : 0;
        }
        if (this.surface != null && Input.GetKey(KeyCode.UpArrow))
        {
            speed = this.surface.speed + this.speedVariation;
            this.surface.speed = speed < this.maxSpeed ? speed : this.maxSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.body.AddTorque(this.TorqueAmount);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.body.AddTorque(-this.TorqueAmount);
        }
    }

}
