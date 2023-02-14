using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class WeaponSwitcher : MonoBehaviour

    {
        [SerializeField] private GameObject pistol;
        [SerializeField] private GameObject rifle;
        public static GameObject activeWeapon;

        void Start()
        {
            activeWeapon = rifle;
            pistol.SetActive(false);
            

        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                if (activeWeapon == rifle)
                {
                    activeWeapon = pistol;
                    pistol.SetActive(true);
                    rifle.SetActive(false);

                }
                else
                {
                    activeWeapon = rifle;
                    rifle.SetActive(true);
                    pistol.SetActive(false);
                }
                
            }
        }
    }
}