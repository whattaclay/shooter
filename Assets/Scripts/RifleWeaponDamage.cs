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
        [SerializeField] private GameObject muzzleEffect;
        
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var fireEffect = Instantiate(muzzleEffect, shootPoint);
                Destroy(fireEffect, 0.25f);
                
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