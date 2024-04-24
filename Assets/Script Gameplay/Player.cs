using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MainCharacter
{
    [SerializeField] private Transform aim;
    private Weapon playerWeapon;
    [SerializeField] private Bullet bulletprefab;
    protected override void Start()
    {
       
        healthpoints = new Health(4);
        playerWeapon = new Weapon(bulletprefab);
        healthpoints.OnHealthChanged.AddListener(ChangedHealth);
    }

    public void ChangedHealth(int health)
    {
       

        if (health <= 0)
        {    GameManager.singleton.EndGame();
            Death();
        }

    }
    public override void Death()
    {
         Destroy(gameObject);
       
    }

    public override void Move (Vector2 direction, float angle)
    {
       base.Move (direction, angle);
    }

    public override void Shoot()
    {
        playerWeapon.Fire(aim.position,aim.rotation,"Enemy");
    }

 
}

