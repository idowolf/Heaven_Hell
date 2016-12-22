using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class playerScript : MonoBehaviour {
    private Rigidbody2D r2d;
    private float acceleration = 0;
    public float accelerationModifier;
    public float baseSpeed;

    // Use this for initialization
    void Start() {
        r2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update() {

        //moving the hand to the mouse position


        // Get the Rigidbody2D component

        /* Move the spaceship when an arrow key is pressed
        Vector3 v = r2d.velocity;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            acceleration = acceleration + Time.deltaTime*accelerationModifier;
            v.x = baseSpeed + acceleration;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            acceleration = acceleration + Time.deltaTime*accelerationModifier;
            v.x = -baseSpeed - acceleration;
        }
        else
        {
            v.x = 0;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
            acceleration = 0;
        r2d.velocity = v;
        */

    }


}