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
    private static float playerDistance = 3;

    private Rigidbody2D rb;
    private Collider2D coll;
    private Collider2D[] colli;
    

    private Vector2 direction;
    private bool follow = false;


    public Masked_Man() : base(health, damage, speed, impactForce,playerDistance) { }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        FlipAnimation(rb);
        PlayerFollow();
       // ProjectileDamage();
       if(Vector3.Distance(transform.position,player.position) < playerDistance)
        {
            MoveForward();
        }
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
            Speed = Speed * iceball.slowEffectPercentage;
            takeDamage(iceball.Damage);
            //Debug.Log(collision.gameObject.name + " " + fireball.damage + " damage Recieved to " + name + ". Health is: " + Health);
        }
        /*
        if (collision.gameObject.CompareTag("Player"))
        {
            Player_Class player = collision.gameObject.GetComponent<Player_Class>();
            player.takeDamage( Damage);
            Debug.Log("Player damaged, heath is: " + player.Health);

        }
        */
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            coll = collision;
            follow = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        follow = false;
    }
    private void MoveForward()
    {
        if (gameObject)
        {
            Vector3 direction = Vector3.Normalize(player.transform.position - transform.position);
            rb.velocity = direction * Speed;
        }else
        {
            rb.velocity=(new Vector2(0, 0));
        }
    }
    
    private void PlayerFollow()
    {
        if (follow && coll)
        {
            MoveForward();
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
    private void ProjectileDamage()
    {

        
        foreach (Collider2D projectile in colli)
        {
            if (projectile.gameObject.CompareTag("FireBall") && colli != null)
            {
                Debug.Log("Fireball touched");
            }
        }
        
    }

    IEnumerator OnCollisionEnter2D(Collision2D[] others)
    {
        //for loop repeats for everything that collides with trigger area
        for (int i = 0; i < others.Length; i++)
        {

            if (others[i].gameObject.tag == "FireBall")
            {
                Debug.Log("Fireball touched");
            }
            else if (others[i].gameObject.tag == "Player")
            {
                
            }
        }

        yield return new WaitForSeconds(1);
    }
}
