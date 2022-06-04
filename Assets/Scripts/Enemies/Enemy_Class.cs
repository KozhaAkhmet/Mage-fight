using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Class : MonoBehaviour
{
    [SerializeField]
    private int _health;
    [SerializeField]
    private int _damage;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private int _impactForce;
    [SerializeField]
    private float _playerDistance;

    public Transform player;

    public Enemy_Class() { }
        
        public Enemy_Class(int health, int damage, float speed , int impactForce, float playerDistance)
        {
            Health = health;
            Damage = damage;
            Speed = speed;
            ImpactForce = impactForce;
            PlayerDistance = playerDistance;
            /*
            Debug.Log("Health is: " + health);
            Debug.Log("Power is: " + power);
            Debug.Log("Name is: " + name);
            */

        }
    private void Start()
    {
        
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
    public int ImpactForce
    {
        get
        {
            return _impactForce;
        }
        set
        {
            _impactForce = value;
        }
    }
    public float PlayerDistance
    {
        get
        {
            return _playerDistance;
        }
        set
        {
            _playerDistance = value;
        }
    }
    public void FlipAnimation(Rigidbody2D rb)
        {
            if (!(rb.velocity.x == 0f))
            {
                transform.rotation = rb.velocity.x < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
            }
        }

}
