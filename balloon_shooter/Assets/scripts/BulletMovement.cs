using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed;
    
    void Start() {
        gameObject.GetComponent<Rigidbody>().AddForce(0, 0, speed * 1000f);
        StartCoroutine(Lifetime());
    }

    IEnumerator Lifetime()
    {
        yield return new WaitForSeconds(8);
        Destroy(gameObject);
    }

    void Update() {
        
    }
}
