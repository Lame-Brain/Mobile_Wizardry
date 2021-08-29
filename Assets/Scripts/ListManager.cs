using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ListManager
{
    public static List<ItemStatic> ITEMLIST = new List<ItemStatic>();
    public static List<MonsterStatic> MONSTERLIST = new List<MonsterStatic>();

    public static void Initialize_Lists()
    {
        ITEMLIST.Clear();
        ITEMLIST.Add(new ItemStatic());


        MONSTERLIST.Clear();
    }
}
