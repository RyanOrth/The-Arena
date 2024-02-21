// https://www.youtube.com/watch?v=iQo02TvVXaU

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamagePopup : MonoBehaviour
{
    private TextMeshPro textMesh; //Reference to damage text
    private Color textColor; //Change the alpha to fade out
    private Transform playerTransform; //Looks towards the player

    private float disappearTimer = 0.75f;
    private float fadeOutSpeed = 5f;
    private float moveYSpeed = 1f;

    public void SetUp(int amount)
    {
        textMesh = GetComponent<TextMeshPro>();
        playerTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
        // playerTransform = Camera.main.transform;
        textColor = textMesh.color;
        textMesh.SetText(amount.ToString());
    }

    private void LateUpdate()
    {
        transform.LookAt(2 * transform.position - playerTransform.position); //Look at player but rotated by 180 degrees
        transform.position += new Vector3(0f, moveYSpeed * Time.deltaTime, 0f); //Move upwards
        disappearTimer -= Time.deltaTime;
        if (disappearTimer <= 0f)
        {
            textColor.a -= fadeOutSpeed * Time.deltaTime;
            if (textColor.a <= 0f){
                Destroy(gameObject);
            }
        }
    }
}
