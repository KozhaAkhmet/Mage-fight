using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : Mage_Class
{
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;
    private BoxCollider2D coll;


    private float dirX,dirY;
    private float mouseDirX;
    
    private enum MovementState { idle, running, jumping, fallng }
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        coll = GetComponent<BoxCollider2D>();
        
    }

    private void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mouseDirX = Camera.main.ScreenToWorldPoint(mousePosition).x - transform.position.x;
        dirX = Input.GetAxisRaw("Horizontal");
        dirY = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(dirX * Speed, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, dirY * Speed);
        UpdateAnimation();
        
        
        
    }
    private void UpdateAnimation()
    { 
        if ( !(mouseDirX == 0f)) 
        {
            transform.rotation = mouseDirX < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }

        if(Input.GetMouseButtonDown(0)){
            SpellCast();
        }
        else
        {
            anim.SetBool("Cast", false);
        }

        if (dirX > 0 || dirX < 0)
        {
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }



    }
    private void SpellCast()
    {
        anim.SetBool("Cast", true);
    }
}

