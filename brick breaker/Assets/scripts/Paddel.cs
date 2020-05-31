using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddel : MonoBehaviour
{
    public Rigidbody2D paddel;
    float speed = 5;
    float maxX=2.4f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        if(x==0)
        {
            stop();
        }
        if(x>0)
        {
            MoveRight();
        }
        if(x<0) 
        {
            MoveLeft();
        }
        Vector3 pos = paddel.transform.position;
        pos.x = Mathf.Clamp(pos.x, -maxX, maxX);
        paddel.transform.position = pos;
    }
    public void MoveRight()
    {
        paddel.velocity = new Vector2(speed, 0);
    }
    public void MoveLeft()
    {
        paddel.velocity = new Vector2(-speed, 0);
    }
    public void stop()
    {
        paddel.velocity = Vector2.zero;
    }

}
