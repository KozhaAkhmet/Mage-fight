using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Masked_Man : Enemy_Class
{
    [SerializeField]
    private static int health = 100;
    [SerializeField] 
    private static float speed = 5f;
    [SerializeField]
    private static int damage = 20;
    [SerializeField]
    private static int impactForce = 2;
    [SerializeField]
    private static float playerDistance = 4.5f;

    private Rigidbody2D rb;
    private Collider2D coll;
    

    private Vector2 direction;


    public Masked_Man() : base(health, damage, speed, impactForce,playerDistance) { }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        FlipAnimation(rb);
        MoveForward();
        // ProjectileDamage();
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("FireBall"))
        {
            FireBall fireball = collision.gameObject.GetComponent<FireBall>();
            takeDamage(fireball.Damage);
            //Debug.Log(collision.gameObject.name + " " + fireball.damage + " damage Recieved to " + name + ". Health is: " + Health);
        }
        if (collision.gameObject.CompareTag("IceBall"))
        {
            IceBall iceball = collision.gameObject.GetComponent<IceBall>();
            Speed = Speed > 0f ? Speed - iceball.slowEffect : 0;
            if (Speed <= 0f) Speed = 0;
            takeDamage(iceball.Damage);
            Debug.Log("Iceball Slow Effect. Now speed is: " + Speed);
            //Debug.Log(collision.gameObject.name + " " + fireball.damage + " damage Recieved to " + name + ". Health is: " + Health);
        }
        
    }

    private void MoveForward()
    {
        if (gameObject)
        {
            if (Vector3.Distance(transform.position, player.position) < playerDistance)
            {
                Vector3 direction = Vector3.Normalize(player.transform.position - transform.position);
                rb.velocity = direction * Speed;
            }
            else
                rb.velocity = Vector2.zero;
        }
    }

    public void takeDamage(int amount)
    {
        Health -= amount;
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
    
}
