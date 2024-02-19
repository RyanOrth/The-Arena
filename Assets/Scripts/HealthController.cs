using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public void TakeDamage(int amount)
    {
        // Spawn health bar
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            TakeDamage(Random.Range(10, 25));
        }
    }
}
