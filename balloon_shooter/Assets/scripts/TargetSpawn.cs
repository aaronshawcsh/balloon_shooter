using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class TargetSpawn : MonoBehaviour
{

    public GameObject player;
    public int maxTargets;
    public List<GameObject> targetPrefabs;

    private GameObject targetSetRuntime;
    void Start()
    {
        targetSetRuntime = GameObject.FindGameObjectWithTag("targetSetRuntime");
        for (int i = 0; i < maxTargets; i++)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        Instantiate(targetPrefabs[Random.Range(0, 3)], new Vector3(Random.Range(-50.0f,50.0f), Random.Range(-10.0f,25.0f),transform.position.z), Quaternion.identity, targetSetRuntime.transform);
    }

    public void TargetDestroyed()
    {
        Spawn();
    }
}
