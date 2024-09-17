using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemChecker : MonoBehaviour
{
    public bool green = false;
    public bool blue = false;
    public bool red = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Green")
        {
            green = true;
        }

        if (collision.gameObject.tag == "Blue")
        {
            blue = true;
        }

        if (collision.gameObject.tag == "Red")
        {
            red = true;
        }
    }
}
