using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePopupManager : MonoBehaviour
{
    #region Singleton
    public static DamagePopupManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.Log("Two instances of damage popup manager exist, removing one.");
            Destroy(gameObject);
        }
    }
    #endregion

    [SerializeField]
    private GameObject damagePopupPrefab;

    public void DisplayDamagePopup(int amount, Transform popupParent)
    {
        GameObject go = Instantiate(damagePopupPrefab, popupParent.transform.position, Quaternion.identity, popupParent);
        go.GetComponent<DamagePopup>().SetUp(amount);
    }
}
