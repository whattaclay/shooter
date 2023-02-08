using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class RifleWeaponDamage : MonoBehaviour

    {
        [SerializeField] private float force = 10;
        [SerializeField] private float damage = 35;
        [SerializeField] private GameObject impactPrefab;
        [SerializeField] private Transform shootPoint;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(shootPoint.position, shootPoint.forward, out var hit))
                {
                    

                    Instantiate(impactPrefab, hit.point, Quaternion.LookRotation(hit.normal, Vector3.up));

                    var destructible = hit.transform.GetComponent<HeatpointObjects>();

                    if (destructible != null)
                    {
                        destructible.ReceiveDamage(damage);
                        
                    }

                    var rigidbody = hit.transform.GetComponent<Rigidbody>();

                    if (rigidbody != null)
                    {
                        rigidbody.AddForce(shootPoint.forward * force, ForceMode.Impulse);
                    }

                }
            }
        }
    }
}