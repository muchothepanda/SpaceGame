using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class Player : MainCharacter
{
    [SerializeField] UIGameover gameover;
    private Weapon playerWeapon;
    public float time;
    public int healthui;

    [SerializeField] private Transform aim;
    [SerializeField] private Bullet bulletprefab;
    [SerializeField] private Camera cam;
    protected override void Start()
    {
        healthpoints = new Health(100);
        playerWeapon = new Weapon(bulletprefab);
        healthpoints.OnHealthChanged.AddListener(ChangedHealth);
    }
    public void ChangedHealth(int health)
    {
        healthui=health;
        if (health <= 0)
        { GameManager.singleton.EndGame();
          Death();
        }
    }
    private void Update()
    {
        Vector2 screenPosition = cam.WorldToScreenPoint(transform.position);
        if (screenPosition.x < 0 && RigidBody.velocity.x < 0)  
        {
            RigidBody.velocity = new Vector2(1,RigidBody.velocity.y);
        }
        if(screenPosition.x > cam.pixelWidth && RigidBody.velocity.x > 0)
        {
            RigidBody.velocity = new Vector2(-1, RigidBody.velocity.y);
        }
        if ((screenPosition.y < 0 && RigidBody.velocity.y < 0)  )
        {
            RigidBody.velocity = new Vector2(RigidBody.velocity.x,1);
        }
        if (screenPosition.y > cam.pixelHeight && RigidBody.velocity.y > 0)
        {
            RigidBody.velocity = new Vector2(RigidBody.velocity.x, -1);
        }
    }
    public override void Death()
    {
        Destroy(gameObject);
        gameover.EndScene();
    }
    public override void Move(Vector2 direction, float angle)
    {
        base.Move(direction, angle);
    }
    public override void Shoot()
    {
        playerWeapon.Fire(aim.position, aim.rotation, "Enemy");
    }
}

