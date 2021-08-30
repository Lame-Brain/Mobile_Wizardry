using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int item_ID;
    public bool isEquipped;
    public bool isIdentified;
    public bool curseActive;

    public Item(int ID)
    {
        this.item_ID = ID;
        this.isEquipped = false;
        this.isIdentified = true;
        this.curseActive = false;
    }

    public ItemStatic getInfo() { return ListManager.ITEMLIST[this.item_ID]; }
}
