using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;


public class ShootingEnemy : Enemy
{
    [SerializeField] private Transform aim;
    [SerializeField] private Bullet BulletPrefab;
    
    public ShootingEnemy(string enemyName) : base(enemyName)
    {
    }
    public override void Move(Vector2 direction, float angle)
    {
        if (Vector2.Distance(target.transform.position, transform.position) >= AttackDistance)
        {
            base.Move(direction, angle);
        }
        if (Vector2.Distance(target.transform.position, transform.position) < AttackDistance)
        {
            base.Move(direction, angle);
            time += Time.deltaTime;
            if (time >= 0f)
            {
                pew();
                time = -2f;
            }
        }
    }
    public void pew()
    {
        Bullet tempBullet = Instantiate(BulletPrefab, aim.position, aim.rotation);
        tempBullet.SetUpBullet("Player", 10);
    }
}