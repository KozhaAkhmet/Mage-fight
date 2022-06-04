using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Player_Class
{
    [SerializeField]
    private static int health = 100;
    [SerializeField]
    private static float speed = 5f;
    [SerializeField]
    private static int damage = 20;
    [SerializeField]
    private static int mana = 100;

    private Rigidbody2D rb;

    

    public Mage() : base(health, damage, speed, mana) { }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void ManaRegeneration()
    {
        
        Mana += 10;
        Debug.Log("Mana: " + Mana);
    }
   
}
