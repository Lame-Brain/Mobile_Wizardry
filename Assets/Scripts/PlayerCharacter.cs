using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter 
{
    public enum Race { Human, Elf, Dwarf, Gnome, Halfling }
    public enum Class { Fighter, Rogue, Priest, Mage, Paladin, Bishop, Ninja, Samurai }
    public int roster_ID;
    public string name;
    public Race race;
    public Class job;
    public int strength, IQ, piety, vitality, agility, luck, age, ac, swings, alignment;
    public float death_Save, wand_Save, breath_Save, petrify_Save, spell_Save;
    public int legacy_HP, max_HP, current_HP, step_HP, xp_Level, xp, xp_Drain, level_Drain;
    public int[] mageSlots, priestSlots;
    public bool[,] mageSpellKnown, priestSpellKnown;
    public string RoomID;
    public bool CritHit, OK, afraid, asleep, paralyzed, stoned, dead, ashes, lost;
    //Equipment
    //public Item equipped_Weapon, equipped_Shield, equipped_Armor, equipped_Accessory;
    //public Item[] inventory //(max 10)
    
}
