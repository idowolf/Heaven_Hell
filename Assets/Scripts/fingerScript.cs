using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fingerScript : MonoBehaviour {
    private Vector3 mousePos;
    public bulletScript bullet;
    public lightningScript lightning;
    public Vector3 dif;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos = new Vector3(mousePos.x, mousePos.y, 0f);
        dif = mousePos - transform.position;
        dif.Normalize();
        float rotZ = Mathf.Atan2(dif.y, dif.x) * Mathf.Rad2Deg;
        if (rotZ > 0 && rotZ < 90)
            rotZ = 0;
        if (rotZ >= 90 && rotZ < 180)
            rotZ = 180;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + 120);


        // When the spacebar is pressed 
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Create a new bullet at “transform.position” 
            // Which is the current position of the ship
            //Quaternion.identity = add the bullet with no rotation

            float x = 4.25576412f * Mathf.Cos((rotZ+180) * Mathf.Deg2Rad);
            float y = 4.25576412f * Mathf.Sin((rotZ+180) * Mathf.Deg2Rad);
            bulletScript instBullet = GameObject.Instantiate(bullet, offsetPosition(x, y), Quaternion.identity);
            instBullet.xFinger = x;
            instBullet.yFinger = y;
            Debug.Log("mousePos" + mousePos);
            Debug.Log("angle=" +rotZ);
            Debug.Log("x=" +x);
            Debug.Log("y=" +y);
            instBullet.bulletSpeed = 20;
        }


        // When the spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            // Create a new bullet at “transform.position” 
            // Which is the current position of the ship
            //Quaternion.identity = add the bullet with no rotation
            float x = 10.25576412f * Mathf.Cos((rotZ + 180) * Mathf.Deg2Rad);
            float y = 10.25576412f * Mathf.Sin((rotZ + 180) * Mathf.Deg2Rad);
            lightningScript instLightning = GameObject.Instantiate(lightning, offsetPosition(x, y), Quaternion.identity);
            instLightning.xFinger = x;
            instLightning.yFinger = y;
            Debug.Log("angle=" + rotZ);
            Debug.Log("x=" + x);
            Debug.Log("y=" + y);
            instLightning.bulletSpeed = 20;
        }
    }

    Vector3 offsetPosition(float xOffset = 0, float yOffset = 0, float zOffset = 0)
    {
        Vector3 pos = transform.position;
        return new Vector3(pos.x - xOffset, pos.y - yOffset, pos.z - zOffset);
    }

}
