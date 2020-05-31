using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D ball;
    //public float ballForce;
    bool gameStarted = false;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space)&& gameStarted ==false)
        {
            transform.SetParent(null);
            ball.isKinematic = false;

            ball.AddForce(new Vector2(Random.Range(200,500), Random.Range(200, 500)));
            gameStarted = true;
        }
    }
  
}
