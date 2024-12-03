using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class IceSpell : Spell
{
    public override void Cast()
    {
        Cast("Frozen");
    }
}
