using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    private GameObject player;
    [SerializeField]
    private float speed;
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        speed = Random.Range(1.5f, 1.51f);
        float step = speed * Time.deltaTime;
    }

    void FixedUpdate() {
        transform.position =
            Vector3.MoveTowards(transform.position, player.transform.position, speed);
    }
}
