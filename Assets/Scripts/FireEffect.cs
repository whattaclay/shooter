using System;
using Unity.VisualScripting;
using UnityEngine;

namespace DefaultNamespace
{
    public class FireEffect: MonoBehaviour
    {
        
        [SerializeField] private GameObject fireEffect;
        [SerializeField] private Transform shootPoint;
        [SerializeField] private float fireLiveTime = 1f;

        private void Update()
        {
            //shootPoint.transform.parent = fireEffect.transform;
            
            if (Input.GetMouseButtonDown(0))
            {

                var fireEffectDeleted =  Instantiate(fireEffect, shootPoint.position, Quaternion.LookRotation(shootPoint.forward, Vector3.up));

               Destroy(fireEffectDeleted, fireLiveTime);
            }
            
            
        }
    }
}