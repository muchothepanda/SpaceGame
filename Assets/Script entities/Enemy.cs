using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MainCharacter
{
    public EnemyTypes EnemyType;
    protected private Player target;
    [SerializeField] protected private float AttackDistance;
    [SerializeField] protected private float time;
    [SerializeField] GameObject[] lootpool;

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
    public void gotnuked()
    {
        Destroy(gameObject);
    }
    public void ChangedHealth(int health)
    {
        Debug.Log("off" + health);
        if (health <= 0)
        {
            Death();
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
    public override void Move(Vector2 direction, float angle)
    {
        if (Vector2.Distance(target.transform.position, transform.position) > AttackDistance)
        {
            base.Move(direction, angle);
        }
        else
        {
            base.Move(direction, angle);
        }
    }
    public override void Death()
    {
        if (UnityEngine.Random.Range(0f, 100f)<= 10)
        {
            int randomnumber = UnityEngine.Random.Range(0, lootpool.Length);
            Instantiate(lootpool[randomnumber],transform.position,Quaternion.identity);
        }
    }
    public override void Shoot()
    {
    }
}
