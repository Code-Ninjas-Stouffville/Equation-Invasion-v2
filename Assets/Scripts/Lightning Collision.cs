using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningCollision : MonoBehaviour
{
    public PlayerMovement p;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            p.lives -= 1;
        }
    }
}
