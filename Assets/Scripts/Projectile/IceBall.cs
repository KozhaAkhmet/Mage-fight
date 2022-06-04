using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBall : Projectile_Class
{
    [SerializeField]
    private static int damage = 20;
    [SerializeField]
    private static float speed = 5f;
    [SerializeField]
    private static int manaCost = 20;
    [SerializeField]
    public float slowEffect = 1.5f;

    IceBall() : base(damage, speed, manaCost) { }

    private Rigidbody2D rb;
    private Vector3 contactPosition;
    private Mage player;
    private float blue = 0f;

    private bool trigger = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Mage>();
    }

    void Update()
    {
        if (!trigger)
            MoveForward();
        else
        {
            if (rb)
            {
                
                rb.velocity = Vector2.zero;
                rb.angularVelocity = 0;
            }

            DestroyProjectile(rb);
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Terrain"))
        {
            trigger = true;
        }
        if (collision.gameObject.CompareTag("Traps"))
            collision.gameObject.GetComponent<Renderer>().material.SetColor( "_Color", new Color(0,0,blue = blue + 0.2f,1));
            

    }
}
