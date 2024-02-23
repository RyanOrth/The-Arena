using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField]
    private Transform damagePopupTransform;
    private float interval = 0.0f;

    public void TakeDamage(int amount)
    {
        // Spawn health bar
        DamagePopupManager.instance.DisplayDamagePopup(amount, damagePopupTransform);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        if (other.gameObject.tag == "Weapon")
        {
            switch (other.gameObject.name)
            {
                case "Mace":
                    TakeDamage(15);
                    break;
                case "Sword":
                    TakeDamage(10);
                    break;
                case "Spear":
                    TakeDamage(5);
                    break;
                case "Axe":
                    TakeDamage(5);
                    break;
                default:
                    break;
            }
        }
    }

}
