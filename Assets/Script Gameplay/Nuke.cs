using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.Burst.Intrinsics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Nuke : MonoBehaviour
{
    [SerializeField] private Transform[] around;
    [SerializeField] private Player player;
    [SerializeField] private Bullet Bulletreference;

    private void Start()
    {
        Destroy(gameObject, 10f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < around.Length; i++) 
            {
                Boom(around[i].position, around[i].rotation, "Enemy"); 
            }
            Destroy(gameObject);
        }
    }
    public void Boom(Vector2 position, Quaternion direction, string tag)
    {
        Bullet tempBullet = GameObject.Instantiate(Bulletreference, position, direction);
        tempBullet.SetUpBullet(tag, 10);
    }
}