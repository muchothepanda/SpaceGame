using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickups : PickUps
{
    [SerializeField] private Weapon newWeapon;

    protected override void PickMe(MainCharacter characterToChange  )
    {
        base.PickMe(characterToChange);
    }
}
