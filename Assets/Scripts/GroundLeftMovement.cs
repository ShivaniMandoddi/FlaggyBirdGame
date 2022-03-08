using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundLeftMovement : MonoBehaviour
{
    public float speed;
    BirdMovement birdMovement;
    // Start is called before the first frame update
    void Start()
    {
        birdMovement = GameObject.Find("Player").GetComponent<BirdMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (birdMovement.isGameOver == false)
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

            if (transform.position.x <= -5.6f)
            {

                transform.position = new Vector2(11.33f, transform.position.y);
            }
        }
    }
}
