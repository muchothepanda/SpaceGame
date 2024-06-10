using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MultiShooter : Enemy
{
    public MultiShooter(string enemyName) : base(enemyName)
    {
    }
    [SerializeField] private Transform aim;
    [SerializeField] private Bullet BulletPrefab;
    public override void Move(Vector2 direction, float angle)
    {
        if (Vector2.Distance(target.transform.position, transform.position) >= AttackDistance)
        {
            speed = 400;
            base.Move(direction, angle);
        }
        if (Vector2.Distance(target.transform.position, transform.position) < AttackDistance)
        {
            speed = 0;
            Shotgun();
            base.Move(direction, angle);
        }
    }
    public void Shotgun()
    {
        Bullet tempBullet = Instantiate(BulletPrefab, aim.position, aim.rotation);
        tempBullet.SetUpBullet("Player", 1);
    }
}
