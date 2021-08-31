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

    public void ClearAttackList() { attack.Clear(); }
    public void AddAttack(int _min, int _max, int _bonus) { this.attack.Add(new Attack(_min, _max, _bonus)); }
}
