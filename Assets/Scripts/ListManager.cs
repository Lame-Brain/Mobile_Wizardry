using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ListManager
{
    public static List<ItemStatic> ITEMLIST = new List<ItemStatic>();
    public static List<MonsterStatic> MONSTERLIST = new List<MonsterStatic>();

    public static void Initialize_Lists()
    {
        //ITEM LIST CONSTRUCTION
        //                                                                                                                               Class       Element                               break   next
        ITEMLIST.Clear();//         ID   name1          name2           slot                  restrict    Price   Qty     toHit   hitDam  swings  AC      protect     protect   special     cast    invoke  chance  form    align
        ITEMLIST.Add(new ItemStatic(0,   "Broken Item", "Broken Item",  ItemStatic.Slot.none, "",         0,      0,      0,      0,      0,      0,      "",         "",       "",         "",     "",     0f,      0,      0));

        //MONSTER LIST CONSTRUCTION
        //                                          single       plural       single        plural                    min   max         HP/     HP                          M   P   spell  elem     T   T   A l l y
        MONSTERLIST.Clear(); //          ID  Icon   name?        name?        name.         name.           class     grp   grp  lvl    lvl    Bonus    XP  spcl    abil    lvl lvl rsist  rsist    1   2   %    ID
        MONSTERLIST.Add(new MonsterStatic(0, 1,     "slime",    "slimes",     "Bubbly",     "Bubblies",     "animal", 2,    2,   1,     3,      1,      55, "",     "",     0,  0,    0,    "P",    0,  10, 10,  1));
        //ADD attacks to MONSTERLIST
        MONSTERLIST[0].AddAttack(1, 1, 0);
    }
}
