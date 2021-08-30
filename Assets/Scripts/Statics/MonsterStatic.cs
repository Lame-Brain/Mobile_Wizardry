using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStatic
{
    public int ID, icon_ID;
    public string name_unidentified_single, name_unidentified_plural, name_identified_single, name_identified_plural, job;
    public int minGrpSize, maxGrpSize, level, HP_perLevel, HP_Bonus, AC, mageLevel, priestLevel, xp;
    public string special, abilities, elementalResistance;
    public int treasure1, treasure2, ally_ID;
    public float allyChance, spellResistance;
    public List<Attack> attack = new List<Attack>();

    public struct Attack
    {
        public int minDamage;
        public int maxDamage;
        public int bnsDamage;

        public Attack(int _a, int _b, int _c)
        {
            this.minDamage = _a;
            this.maxDamage = _b;
            this.bnsDamage = _c;
        }
    }
    

    public MonsterStatic(int _id, int _icon,
                           string _name1, string _name2, string _name3, string _name4, string _class,
                           int _min_Group, int _max_Group, int _level, int _hp_per_level, int _hp_bonus,
                           int _xp,
                           string _special, string _abilities, int _mage, int _priest,
                           float _spellResit, string _elementResist,
                           int _treasure1, int _treasure2, float _allyChance, int _ally_ID)
    {
        this.ID = _id;
        this.icon_ID = _icon;
        this.name_unidentified_single = _name1;
        this.name_unidentified_plural = _name2;
        this.name_identified_single = _name3;
        this.name_identified_plural = _name4;
        this.job = _class;
        this.minGrpSize = _min_Group;
        this.maxGrpSize = _max_Group;
        this.level = _level;
        this.HP_perLevel = _hp_per_level;
        this.HP_Bonus = _hp_bonus;
        this.xp = _xp;
        this.special = _special;
        this.abilities = _abilities;
        this.mageLevel = _mage;
        this.priestLevel = _priest;
        this.allyChance = _allyChance;
        this.spellResistance = _spellResit;
        this.elementalResistance = _elementResist;
        this.treasure1 = _treasure1;
        this.treasure2 = _treasure2;
        this.ally_ID = _ally_ID;
    }

    public void ClearAttackList() { attack.Clear(); }
    public void AddAttack(int _min, int _max, int _bonus) { this.attack.Add(new Attack(_min, _max, _bonus)); }
}
