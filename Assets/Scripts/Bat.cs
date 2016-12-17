using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour {

    Animator anim;
    private Rigidbody2D r2d;
    public int speed = 5;

    void Start ()
    {
        anim = GetComponent<Animator>();
        r2d = GetComponent<Rigidbody2D>();
        Vector3 v = r2d.velocity;
        v.y = speed;
        r2d.velocity = v;
        transform.Translate(Vector3.up * 3f * Time.deltaTime);
        transform.eulerAngles = new Vector3(0, 0);
    }


    void Update()

    {
        //Movement();

        //{
        //    float move = Input.GetAxis("Horizontal");
        //    anim.SetFloat("Speed", move);
        //}
    }

    void Movement()

    { 
        if(Input.GetKey (KeyCode.D))
        {
            transform.Translate(Vector2.right * 3f * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector2.right * 3f * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }


        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * 3f * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 0);
        }


        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.up * 3f * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 0);
        }
    }


    void OnBecameInvisible()
    {
        // Destroy the bullet 
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        var name = other.gameObject.name;
        if (name == "bullet(Clone)")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        if (name == "lightning(Clone)")
        {
            Destroy(gameObject);
        }
        if (name == "spaceship")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Application.Quit();
        }

    }















    public class enemyScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    }
}