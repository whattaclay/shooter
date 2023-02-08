
using UnityEngine;

public class HeatpointObjects : MonoBehaviour
{
    [SerializeField] private float hpCurrent = 100;

    public void ReceiveDamage(float damage)
    {
        hpCurrent = hpCurrent - damage;

        if (hpCurrent < 0f)
        {
            Destroy(gameObject);
        }
    }
}
