using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float birdSpeed;
    Rigidbody2D rb;
    public int angle, minAngle, maxAngle;
    void Start()
    {
       gameObject.AddComponent<Rigidbody2D>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Bird movement will start after left click mouse button
            BirdFlapJump();
            //transform.Translate(Vector2.right * 4 * Time.deltaTime);
        }
        BirdRotation();
    }

    private void BirdRotation()
    {
        if (rb.velocity.y > 0)
        {
            if (angle <= maxAngle)
            {
                angle = angle + 4;
            }
        }
        else if (rb.velocity.y < 0)
        {
            if (angle >= minAngle)
            {
                angle = angle - 4;
            }
        }
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    private void BirdFlapJump()
    {
        rb.velocity = Vector2.zero;
        rb.velocity = new Vector2(rb.velocity.x, birdSpeed);
    }
}
