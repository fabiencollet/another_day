using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public enum ItemType 
    { 
        Swissknife,
        Pickaxe,
        Axe,
    }

    public ItemType itemType;
    public int amount;
}
