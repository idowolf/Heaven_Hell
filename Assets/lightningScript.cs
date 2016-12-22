using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightningScript : MonoBehaviour
{
    public int speed = -6;
    private Rigidbody2D r2d;
    public Vector3 mousePos;
    public float bulletSpeed;
    public float xFinger;
    public float yFinger;
    // Use this for initialization
    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos = new Vector3(mousePos.x, mousePos.y, 0f);
        Vector3 dif = mousePos - transform.position;
        dif.Normalize();
        float rotZ = Mathf.Atan2(yFinger, xFinger) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + 90);
        Destroy(gameObject, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += transform.up * bulletSpeed * Time.deltaTime;
    }
}
