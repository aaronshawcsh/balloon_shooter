using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField]
    private int health;

    public float minTumble = 5.0f;
    public float maxTumble = 5.5f;

    public float minSpeed = 4f;
    public float maxSpeed = 5f;
    
    private TargetSpawn targetSpawn;
    
    private GameObject player;
    
    [SerializeField]
    private float speed;

    [SerializeField]
    private float tumble;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
        speed = Random.Range(minSpeed, maxSpeed);
        tumble = Random.Range(minTumble, maxTumble);
        
        health = 100;
        
        //transform.Rotate(Random.Range(-90f, 90f), Random.Range(-90f, 90f), Random.Range(-90f, 90f));

        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
        targetSpawn = transform.parent.gameObject.GetComponentInChildren<TargetSpawn>();
    }

    void FixedUpdate() {
        if (health <= 0)
        {
            Destroy(gameObject);
            targetSpawn.TargetDestroyed();
        }
        
        float step = speed * Time.deltaTime * 80;
        transform.position =
            Vector3.MoveTowards(transform.position, player.transform.position, step);
        
        if (Vector3.Distance(transform.position, targetSpawn.player.transform.position) < 0.01f)
        {
            //EndLevel();
        }
    }

    public void Damage(int damage)
    {
        health -= damage;
    }
}
