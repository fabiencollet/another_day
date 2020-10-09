using UnityEngine;

public class Items_World : MonoBehaviour
{
    // Start is called before the first frame update
    /*public static ItemsWorld SpawnItemWorld(Items items)
    {
        Instantiate();
    }*/

    private Items Items;

    public void SetItem (Items items)
    {
        this.Items = items;
    }

}
