

using UnityEngine;

public class HeatpointObjects : MonoBehaviour
{
    [SerializeField] private float hpCurrent = 100;
    [SerializeField] private GameObject DissapiarePrefab;
    public void ReceiveDamage(float damage)
    {
        hpCurrent = hpCurrent - damage;

        if (hpCurrent < 0f)
        {


            Instantiate(DissapiarePrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
