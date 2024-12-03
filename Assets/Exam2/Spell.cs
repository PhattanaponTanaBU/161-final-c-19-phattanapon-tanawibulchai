using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Spell : MonoBehaviour
{
    //Attributes


    //Method
    public virtual void Cast()
    {
        Debug.Log($"Start Simulation Generic Spell Cassting...");
        Debug.Log($"Casting generic spell!");
    }

    public void Cast(string spellName)
    {
        Debug.Log($"Casting {spellName} spell to goblin!");
    }
    
    public void Cast(string spellName, int powerLevel)
    {
        Debug.Log($"Casting {spellName} to slime with power level of {powerLevel!}");
    }

    void Start()
    {
        Cast();
    }

}
