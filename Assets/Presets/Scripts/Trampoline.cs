using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    private Rigidbody2D player;
    [SerializeField] private float jumpForce = 20;

    private void Start()
    {
        player = GetComponent<Rigidbody2D>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Tramp"))
        {
            Debug.Log("Trampoline Jump");
            player.velocity = new Vector2(0,jumpForce);
        }
    }
}
