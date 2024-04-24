using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MainCharacter
{
    private Player target;
    [SerializeField] private float AttackDistance;
    [SerializeField] private float time;


    protected override void Start()
    {
        base.Start();
        healthpoints.OnHealthChanged.AddListener(ChangedHealth);
    }
    public void SetUpEnemy(int healthParam)
    {
        
        target = FindObjectOfType<Player>();
        healthpoints = new Health(healthParam);
        
    }
    public void ChangedHealth(int health)
    {
        Debug.Log("off" + health);
        if (health <= 0)
        {
            Destroy(gameObject);
            GameManager.singleton.scoreManager.IncreaseScore();
        }
    }
    private void FixedUpdate()
    {
        if(target != null)
        {
            Vector2 direction = target.transform.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Move(direction, angle);
        }
       

    }
    public Enemy ( string enemyName)
        
    {

    }

   

    public override void Death()
    {
        
    }

    public override void Move(Vector2 direction,float angle)
    {
        if (Vector2.Distance(target.transform.position, transform.position) > AttackDistance)
        {
            base.Move(direction, angle);
        }

        else
        {
            base.Move(direction, angle);


            time += Time.deltaTime;
            if (time>=0f)
            {
                target.ReceiveDamage();
                time = -1f;
                
            }
            
        }
        
        
    }

    public override void Shoot()
    {
      
    }
     

    
}
