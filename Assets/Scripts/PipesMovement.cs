using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMovement : MonoBehaviour
{
    public float speed;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        if(transform.position.x<-2.8f)
        {
            // transform.position = new Vector2(4.5f, transform.position.y);
            Destroy(gameObject);
        }
        
        
    }
    private void OnBecameInvisible()
    {
        //Destroy(gameObject);
        //gameObject.SetActive(false);
    }
}
