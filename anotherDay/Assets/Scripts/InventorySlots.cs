using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.VersionControl;
using UnityEngine;

public class InventorySlots : MonoBehaviour
{
    private List<Items> itemList;

    public InventorySlots()      
    {
        itemList = new List<Items>();

    }
    public void AddItem(Items items)
    {
        itemList.Add(items);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
