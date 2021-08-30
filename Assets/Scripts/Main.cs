using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ListManager.Initialize_Lists();
        Item item = new Item(0);
        Debug.Log("is " + item.getInfo().name_identified + " equipped? " + item.isEquipped);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
