using System.Collections;
using System.Collections.Generic;

using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Health
{
    public UnityEvent <int> OnHealthChanged;
    public int currentHealth;
  
    public void TakeDamage(int damage)
    {
        Debug.Log("itsworking"+ currentHealth);
        currentHealth -= damage;
        OnHealthChanged.Invoke(currentHealth);
    }
    public void TakeDamage()
    {
        currentHealth -= 1;
        OnHealthChanged.Invoke(currentHealth);
    }
    public void heal(int Heal)
    {
        currentHealth += Heal;
        OnHealthChanged.Invoke(currentHealth);
    }
    public void heal()
    {
        currentHealth += 25;
        OnHealthChanged.Invoke(currentHealth);
        Debug.Log("itsworking" + currentHealth);
    }

    public Health (int maxHealth)
    {
        currentHealth = maxHealth;
        OnHealthChanged= new UnityEvent<int>();
        
    }
    
}
