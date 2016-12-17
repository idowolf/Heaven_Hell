using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class playerScript : MonoBehaviour {
    public bulletScript bullet;
    public lightningScript lightning;
    private Rigidbody2D r2d;

    // Use this for initialization
    void Start() {
        r2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update() {
        // Get the Rigidbody2D component

        // Move the spaceship when an arrow key is pressed
        Vector3 v = r2d.velocity;
        if (Input.GetKey(KeyCode.RightArrow))
            v.x = 10;
        else if (Input.GetKey(KeyCode.LeftArrow))
            v.x = -10;
        else
            v.x = 0;
        r2d.velocity = v;


        // When the spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Create a new bullet at “transform.position” 
            // Which is the current position of the ship
            // Quaternion.identity = add the bullet with no rotation
            GameObject.Instantiate(bullet, offsetPosition(0.5f,4.5f), Quaternion.identity);
        }


        // When the spacebar is pressed
        if (Input.GetKeyDown(KeyCode.X))
        {
            // Create a new bullet at “transform.position” 
            // Which is the current position of the ship
            // Quaternion.identity = add the bullet with no rotation
            GameObject.Instantiate(lightning, offsetPosition(0.5f,10), Quaternion.identity);
        }
    }


    Vector3 offsetPosition(float xOffset = 0,float yOffset = 0, float zOffset = 0) {
        Vector3 pos = transform.position;
        return new Vector3(pos.x - xOffset, pos.y - yOffset, pos.z - zOffset);
    }
}