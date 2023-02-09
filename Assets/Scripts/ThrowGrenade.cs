using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowGrenade : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float throwforce = 40f;

    [SerializeField] private GameObject grenadePrefab;
    // Update is called once per frame
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
