using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet: MonoBehaviour 
{
    public float bulletspeed;
    private int damage;
    private string targetTag;
    private void Start()
    {
        Destroy(gameObject, 3f);
    }
    public void SetUpBullet(string tag,int damageParam)
    {
        targetTag = tag;
        damage= damageParam;
    }
    private void Update()
    {
        transform.Translate(Vector2.up* bulletspeed*Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        { 
            collision.GetComponent<IDamageable>().ReceiveDamage(damage);
            Destroy(gameObject);
        }
    }
}
