using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batFactoryScript : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTime = 2;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("addEnemy", 0, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void addEnemy()
    {
        Renderer rd = GetComponent<Renderer>();
        var x1 = transform.position.x - rd.bounds.size.x / 2;
        var x2 = transform.position.x + rd.bounds.size.x / 2;
        var spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);
        Instantiate(enemy, spawnPoint, Quaternion.identity);

    }
}
