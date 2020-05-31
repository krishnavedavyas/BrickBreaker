using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    TextManager tm;
    // Start is called before the first frame update
    void Start()
    {
        tm = GameObject.Find("Textmanager").GetComponent< TextManager > ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Ball")
        {
            tm.incrementScore();
            Destroy(gameObject);
        }
     
    }
}
