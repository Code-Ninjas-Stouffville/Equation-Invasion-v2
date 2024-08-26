using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public ShootProjectile direction;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<ShootProjectile>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction.offset * Time.deltaTime * speed;
        Invoke("DestroyObject", 5);
    }

    public void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "ForceField")
        {
            collision.gameObject.SetActive(false);
        }
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
