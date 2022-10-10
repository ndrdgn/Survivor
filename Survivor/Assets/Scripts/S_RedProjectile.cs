using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_RedProjectile : SpellBase 
{
    [SerializeField] GameObject redProjectilePrefab;

    public override void Attack()
    {
        GameObject fireball = Instantiate(redProjectilePrefab, transform.position, transform.rotation);
        fireball.GetComponent<RP_Movement>().spellDamage = spellStats.damage;
    }
}
