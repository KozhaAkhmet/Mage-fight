using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Class : MonoBehaviour
{
    private int _damage = 10;
    private float _speed = 5f;
    private int _manaCost = 100;
    public Projectile_Class() { }
    public Projectile_Class(int damage , float speed, int manaCost)
    {
        Damage = damage;
        Speed = speed;
        ManaCost = manaCost;
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
    public int ManaCost
    {
        get
        {
            return _manaCost;
        }
        set
        {
            _manaCost = value;
        }
    }
    public void DestroyProjectile(Rigidbody2D rb)
    {
        Destroy(rb.gameObject);
    }
    public void MoveForward()
    {
        transform.position += transform.right * Time.deltaTime * Speed;
    }

}
