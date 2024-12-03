using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSpell : Spell
{
    // Start is called before the first frame update
    void Start()
    {
        Cast("Strom", 5);
        Cast("Wind Current", 2, new Vector2(5,8));
    }

    public void Cast(string spellName, int powerLevel, Vector2 pos)
    {
        Debug.Log($"Casting {spellName} at {pos} with power level of {powerLevel!}");
    }
}
