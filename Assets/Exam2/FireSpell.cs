using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    // Start is called before the first frame update
    public override void Cast()
    {
        Debug.Log($"Casting a fireball spell to burn them all!");
    }
}
