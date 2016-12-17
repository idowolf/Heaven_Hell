using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightningScript : MonoBehaviour
{
    public int speed = -6;
    private Rigidbody2D r2d;

    // Use this for initialization
    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        Vector3 v = r2d.velocity;
        v.y = speed;
        r2d.velocity = v;
        Destroy(gameObject, 0.1f);

    }

    // Update is called once per frame
    void Update()
    {
    }

    // Function called when the object goes out of the screen
    void OnBecameInvisible()
    {
        // Destroy the bullet 
        Destroy(gameObject);
    }

}
