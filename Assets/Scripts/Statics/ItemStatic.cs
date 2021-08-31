using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStatic
{
    public enum Slot { none, Weapon, Shield, Armor, Accessory, Consum }
    public int ID;
    public string name_unidentified, name_identified, classRestriction, special;
    public Slot slot;
    public int price, boltac, hitMod, hitMin, hitMax, hitBonus, swings, AC_Bonus;
    public string classProtection, elementalProtection, cast, invoke;
    public float breakChance;
    public int nextForm, alignment;

    /*
    public ItemStatic(int _id, string _name1, string _name2, Slot _slot, string _restrict, int _price, int _qty,
                        int _toHit, int _hitDam, int _swings, int _AC_Bonus, 
                        string _classProtect, string _elementProtect, string _special,
                        string _cast, string _invoke, float _breakChance, 
                        int _nextForm, int _alignment)
    {
        this.ID = _id;
        this.name_identified = _name1;
        this.name_unidentified = _name2;
        this.slot = _slot;
        this.classRestriction = _restrict;
        this.price = _price;
        this.qtyInShop = _qty;
        this.hitMod = _toHit;
        this.hitDam = _hitDam;
        this.swings = _swings;
        this.AC_Bonus = _AC_Bonus;
        this.classProtection = _classProtect;
        this.elementalProtection = _elementProtect;
        this.special = _special;
        this.cast = _cast;
        this.invoke = _invoke;
        this.breakChance = _breakChance;
        this.nextForm = _nextForm;
        this.alignment = _alignment;
    } */

}