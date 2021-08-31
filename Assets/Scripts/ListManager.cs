using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ListManager: MonoBehaviour
{
    public TextAsset itemList, monsterList, attackList;    
    public static List<ItemStatic> ITEMLIST = new List<ItemStatic>();
    public static List<MonsterStatic> MONSTERLIST = new List<MonsterStatic>();

    public void Initialize_Lists()
    {
        //ITEM LIST CONSTRUCTION (21)
        string[] data = itemList.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);        
        for(int _i = 21; _i < data.Length; _i += 21)
        {
            ItemStatic _IS = new ItemStatic(); //I have to have this here so that every time, _IS is a new item, and does not overwrite previous entries to ITEMLIST
            _IS.ID = int.Parse(data[_i]);
            _IS.name_identified = data[_i + 1];
            _IS.name_unidentified = data[_i + 2];
            if (data[_i + 3] == "Misc") _IS.slot = ItemStatic.Slot.none;
            if (data[_i + 3] == "Weapon") _IS.slot = ItemStatic.Slot.Weapon;
            if (data[_i + 3] == "Shield") _IS.slot = ItemStatic.Slot.Shield;
            if (data[_i + 3] == "Armor") _IS.slot = ItemStatic.Slot.Armor;
            if (data[_i + 3] == "Accessory") _IS.slot = ItemStatic.Slot.Accessory;
            if (data[_i + 3] == "Consum") _IS.slot = ItemStatic.Slot.Consum;
            _IS.classRestriction = data[_i + 4];
            _IS.price = int.Parse(data[_i + 5]);
            _IS.boltac = int.Parse(data[_i + 6]);
            _IS.hitMod = int.Parse(data[_i + 7]);
            _IS.hitMin = int.Parse(data[_i + 8]);
            _IS.hitMax = int.Parse(data[_i + 9]);
            _IS.hitBonus = int.Parse(data[_i + 10]);
            _IS.swings = int.Parse(data[_i + 11]);
            _IS.AC_Bonus = int.Parse(data[_i + 12]);
            _IS.classProtection = data[_i + 13];
            _IS.elementalProtection = data[_i + 14];
            _IS.special = data[_i + 15];
            _IS.cast = data[_i + 16];
            _IS.invoke = data[_i + 17];
            _IS.breakChance = float.Parse(data[_i + 18]);
            _IS.nextForm = int.Parse(data[_i + 19]);
            _IS.alignment = int.Parse(data[_i + 20]);
            ITEMLIST.Add(_IS); //Write the completed item to the list.
        }
        //MONSTER LIST CONSTRUCTION (24)
        data = monsterList.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None); //recycling data local variable
        for (int _i = 24; _i < data.Length; _i += 24)
        {
            MonsterStatic _MS = new MonsterStatic();
            _MS.ID = int.Parse(data[_i]);
            _MS.icon_ID = int.Parse(data[_i + 1]);
            _MS.name_unidentified_single = data[_i + 2];
            _MS.name_unidentified_plural = data[_i + 3];
            _MS.name_identified_single = data[_i + 4];
            _MS.name_identified_plural = data[_i + 5];
            _MS.job = data[_i + 6];
            _MS.minGrpSize = int.Parse(data[_i + 7]);
            _MS.maxGrpSize = int.Parse(data[_i + 8]);
            _MS.level = int.Parse(data[_i + 9]);
            _MS.HP_perLevel = int.Parse(data[_i + 10]);
            _MS.HP_Bonus = int.Parse(data[_i + 11]);
            _MS.AC = int.Parse(data[_i + 12]);
            _MS.xp = int.Parse(data[_i + 13]);
            _MS.special = data[_i + 14];
            _MS.abilities = data[_i + 15];
            _MS.mageLevel = int.Parse(data[_i + 16]);
            _MS.priestLevel = int.Parse(data[_i + 17]);
            _MS.allyChance = float.Parse(data[_i + 18]);
            _MS.ally_ID = int.Parse(data[_i + 19]);
            _MS.spellResistance = float.Parse(data[_i + 20]);
            _MS.elementalResistance = data[_i + 21];
            _MS.treasure1 = int.Parse(data[_i + 22]);
            _MS.treasure2 = int.Parse(data[_i + 23]);
            MONSTERLIST.Add(_MS); //Write monster to List
        }
        //ATTACK LIST CONSTRUCTION (38, 19)
        int _index;
        data = attackList.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None); //recycling data local variable
        for(int _i = 38; _i < data.Length-1; _i += 19)
        { //Checks to see if attacks have a value, then adds them to the monster list.
            _index = int.Parse(data[_i]);
            if (data[_i + 1] != "") MONSTERLIST[_index].AddAttack(int.Parse(data[_i + 1]), int.Parse(data[_i + 2]), int.Parse(data[_i + 3]));
            if (data[_i + 4] != "") MONSTERLIST[_index].AddAttack(int.Parse(data[_i + 4]), int.Parse(data[_i + 5]), int.Parse(data[_i + 6]));
            if (data[_i + 7] != "") MONSTERLIST[_index].AddAttack(int.Parse(data[_i + 7]), int.Parse(data[_i + 8]), int.Parse(data[_i + 9]));
            if (data[_i + 10] != "") MONSTERLIST[_index].AddAttack(int.Parse(data[_i + 10]), int.Parse(data[_i + 11]), int.Parse(data[_i + 12]));
            if (data[_i + 13] != "") MONSTERLIST[_index].AddAttack(int.Parse(data[_i + 13]), int.Parse(data[_i + 14]), int.Parse(data[_i + 15]));
            if (data[_i + 16] != "") MONSTERLIST[_index].AddAttack(int.Parse(data[_i + 16]), int.Parse(data[_i + 17]), int.Parse(data[_i + 18]));            
        }
    }
}
