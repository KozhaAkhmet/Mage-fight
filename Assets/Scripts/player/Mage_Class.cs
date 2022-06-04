using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage_Class : MonoBehaviour
{
    private int _health = 100;
    private int _damage = 50;
    private int _speed = 7;
    private int _jumpForce = 14;
    public Mage_Class () { }
    public Mage_Class(int health , int damage , int speed)
    {

        Health = health;
        Damage = damage;
        Speed = speed;
    }
    /* private void Die()
     {
         if(mage.Health == 0)
         {
             Destroy(rb.gameObject);
         }
     }
    */
    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
        }
    }
    public int Damage
    {
        get
        {
            return _damage;
        }
        set
        {
            _damage = value;
        }
    }
    public int Speed
    {
        get
        {
            return _speed;
        }
        set
        {
            _speed = value;
        }
    }
    public int JumpForce
    {
        get
        {
            return _jumpForce;
        }
        set
        {
            _jumpForce = value;
        }
    }
}
