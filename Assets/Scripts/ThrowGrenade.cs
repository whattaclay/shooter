using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowGrenade : MonoBehaviour
{
  
    [SerializeField] private float throwforce = 40f;

    [SerializeField] private GameObject grenadePrefab;
  
    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            throwGrenade();
        }
    }


    void throwGrenade()
    {
      GameObject grenade =  Instantiate(grenadePrefab, transform.position, transform.rotation);
      Rigidbody rb = grenade.GetComponent<Rigidbody>();
      rb.AddForce(transform.forward * throwforce, ForceMode.VelocityChange);


    }
    
}
