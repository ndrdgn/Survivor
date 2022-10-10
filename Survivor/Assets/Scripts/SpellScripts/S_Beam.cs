using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class S_Beam : SpellBase
{
    [SerializeField] GameObject blueBeamPrefab;
    public override void Attack()
    {
        blueBeamPrefab.GetComponent<S_BeamDamage>().spellDamage = spellStats.damage;
        blueBeamPrefab.SetActive(true);
    }
}
