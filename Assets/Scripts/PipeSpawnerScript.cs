using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipePrefab;
    public float yMin;
    public float yMax;
    float time;
    BirdMovement birdMovement;
    void Start()
    {
        birdMovement = GameObject.Find("Player").GetComponent<BirdMovement>();
        // PipeSpawner();
        if (birdMovement.isGameOver == false)
        {
            InvokeRepeating("PipeSpawner", 2f, 2f);
        }
    }

    private void PipeSpawner()
    {
        
        GameObject newPipe= Instantiate(pipePrefab);
        newPipe.transform.position = new Vector2(transform.position.x, UnityEngine.Random.Range(yMin, yMax));
    }

    // Update is called once per frame
    void Update()
    {
       /* time = time + Time.deltaTime;
        if (time > 2f)
        {
            PipeSpawner();
            time = 0f;
        }
       */
    }
    
}
