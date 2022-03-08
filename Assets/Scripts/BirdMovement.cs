using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float birdSpeed;
    public float score;
    Rigidbody2D rb;
    float time;
    public Text scoreText;
    public Text gameOver;
    public int angle, minAngle, maxAngle;
    public bool isGameOver=false;
   // public GameObject upperPipe;
    //public GameObject lowerPipe;
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
            if(isGameOver==false)
                BirdFlapJump();
            //transform.Translate(Vector2.right * 4 * Time.deltaTime);
        }
        //float xPosition = UnityEngine.Random.Range(1f, 4f);
        /*float yPosition = UnityEngine.Random.Range(3.5f, 6.0f);
        
        time = time + Time.deltaTime;
        if (time > 3f)
        {
            Instantiate(lowerPipe, new Vector2(2, -1.88f), Quaternion.identity);
            Instantiate(upperPipe, new Vector2(2, yPosition), Quaternion.identity);
            time = 0f;
        }*/
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag=="Pipe" || collision.gameObject.tag=="Ground")
        {
            Debug.Log("Game Over");
            isGameOver = true;
            gameOver.text = "Game Over!!";
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        score=score+10;
        Debug.Log("Score:" + score);
        scoreText.text = score.ToString();
       
    }
}
