using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;
    public int throwableCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            offset = transform.localScale.x * new Vector3(1, 0, 0);
            Vector3 throwablePosition = transform.position + offset;
            Instantiate(objectThrown, throwablePosition, transform.rotation);
        }
    }
}
