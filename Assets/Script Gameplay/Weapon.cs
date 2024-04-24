using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "create Weapon")]
public class Weapon : ScriptableObject
{
    [SerializeField] private string weaponName;
    [SerializeField] private int damage;
    public float fireRate;
    [SerializeField]private Bullet Bulletreference; 
    
    
    

    public void Fire(Vector2 position, Quaternion direction,string tag)
    {
        Bullet tempBullet= GameObject.Instantiate(Bulletreference, position,direction);
        tempBullet.SetUpBullet(tag,1);
    }
    
    
    public Weapon() 
    { 



    }

    public Weapon (Bullet Bulletprefab)
    {
        Bulletreference = Bulletprefab;
    }

  

    
    
}
