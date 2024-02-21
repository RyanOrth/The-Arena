using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Microsoft.Unity.VisualStudio.Editor;
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

    void OnCollisionEnter(Collision other)
    {
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

    private void Update()
    {
        // if (Input.GetMouseButton(0))
        // {
        if (interval > 1)
        {
            TakeDamage(Random.Range(10, 25));
            interval = 0;
        }
        interval += Time.deltaTime;
        // }
    }
}
