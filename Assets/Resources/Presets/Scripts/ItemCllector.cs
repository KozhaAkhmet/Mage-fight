using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCllector : MonoBehaviour
{
    private int cherries = 0;

    [SerializeField] private Text pointsText;
    [SerializeField] private AudioSource collectSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Kiwi"))
        {
            collectSound.Play();
            Destroy(collision.gameObject);
            cherries++;
            Debug.Log("Cherries: " + cherries);
            pointsText.text = "Points: " + cherries;
        }
    }
}
