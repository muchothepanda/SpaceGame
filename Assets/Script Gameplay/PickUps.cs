using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUps : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            PickMe(collision.gameObject.GetComponent<MainCharacter>());
            
        }
    }

    protected virtual void PickMe(MainCharacter characterToChange)
    {
        Destroy(gameObject);
    }
}
