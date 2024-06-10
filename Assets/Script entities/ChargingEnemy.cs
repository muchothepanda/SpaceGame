using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargingEnemy : Enemy
{
    public ChargingEnemy(string enemyName) : base(enemyName)
    {
    }
    public override void Move(Vector2 direction, float angle)
    {
        if (Vector2.Distance(target.transform.position, transform.position) > AttackDistance)
        {
            base.Move(direction, angle);
        }
        else
        {
            base.Move(direction, angle);
            time += Time.deltaTime;
            if (time >= 0f)
            {
                target.ReceiveDamage();
                time = -0.5f;
            }
        }
    }
}
