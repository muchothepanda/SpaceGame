using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingEnemy : Enemy
{
    public ExplodingEnemy(string enemyName) : base(enemyName)
    {
    }

    public override void Shoot()
    {
        Debug.Log("kaboom");
    }
   // public ExplodingEnemy(string newEnemyName) :base(newEnemyName)
   // {
    //    Debug.Log("kaboom");
   // }  
 

    public override void Death()
    {

    }
}
