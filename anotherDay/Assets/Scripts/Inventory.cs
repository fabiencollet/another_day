using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.VersionControl;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Items> itemList;

    public Inventory()      
    {
        itemList = new List<Items>();

    }
    public void AddItem(Items items)
    {
        itemList.Add(items);
    }

}
