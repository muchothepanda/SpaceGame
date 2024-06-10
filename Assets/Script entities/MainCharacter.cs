using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public abstract class MainCharacter : MonoBehaviour, IDamageable
{
    public Health healthpoints;
    [SerializeField] protected private float speed;
    public Weapon weapon;

    [SerializeField] protected Rigidbody2D RigidBody;

    protected virtual void Start()
    {
       
        healthpoints = new Health(5);
    }

    public abstract void Shoot();

    public abstract void Death();

    public void ReceiveDamage()
    {
       
        healthpoints.TakeDamage();
    }
    public void ReceiveDamage(int damage)
    {
       
        healthpoints.TakeDamage(damage);
    }
  


    public virtual void Move(Vector2 direction, float angle)
    {

        RigidBody.AddForce(direction * speed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(0,0,angle-90);
        
    }

    public void Heal()
    {
          healthpoints.heal();
    }
}
