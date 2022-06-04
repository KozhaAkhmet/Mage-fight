using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : Projectile_Class
{
    [SerializeField]
    private static int damage = 30;
    [SerializeField]
    private static float speed = 5f;
    [SerializeField]
    private static int manaCost = 20;

    FireBall() : base(damage, speed, manaCost) { }

    private Rigidbody2D rb;
    private Vector3 contactPosition;
    private Mage player;

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
        //transform.rotation = Quaternion.FromToRotation( rb.velocity, new Vector3( collision.contacts[0] ,0));
        if (!collision.gameObject.CompareTag("Terrain"))
        {
            //Vector3. collision.contacts[0].normal
            //transform.position = Vector3. collision.contacts[0];
            trigger = true;
        }
        
    }
    
}
