using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Class : MonoBehaviour
{
    private int _health = 100;
    private int _damage = 10;
    private float _speed = 5f;
    private int _mana = 100;
    public Player_Class() {  }
    public Player_Class(int health, int damage,float speed, int mana)
    {
        Health = health;
        Damage = damage;
        Speed = speed;
        Mana = _mana;
        /*
        Debug.Log("Health is: " + health);
        Debug.Log("Power is: " + power);
        Debug.Log("Name is: " + name);
        */

    }
    public int Mana
    {
        get
        {
            return _mana;
        }
        set
        {
            _mana = value;
        }
    }
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
    public float Speed
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

    public void takeDamage(int amount)
    {
        Health -= amount;
        if(Health<=0)
        {
            Destroy(this.gameObject);
        }
    }
    public bool manaUse(int manaAmount)
    {
        if (Mana > 0)
        {
            Mana -= manaAmount;
            Debug.Log(Mana);
            return true;
        }
        if (Mana <= 0)
        {
            Mana = 0;
            Debug.Log("Out of mana");
            return false;
        }
        return false;
    }
    
}
