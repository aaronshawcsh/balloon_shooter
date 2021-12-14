using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : MonoBehaviour
{
    public int damage;

    public GameObject weapon;
    void Start() {
        weapon = GameObject.FindGameObjectWithTag("weapon");
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        //fire
        Transform t = Camera.main.transform;
        LayerMask mask = LayerMask.GetMask("Asteroid");

        RaycastHit raycastHit;
        if (Physics.Raycast(t.position, t.forward, out raycastHit, 150.0f, mask))
        {
            raycastHit.transform.gameObject.GetComponent<Target>().Damage(damage);
        }
        //muzzle flash
        //weapon recoil
    }
}
