using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Item[] items;

    public void SaveItems()
    {
        for (var i = 0; i < items.Length; i++)
        {
            //  Item 1: Id 1 (12)     "Item.1" -> 12
            //  Item 2: Id 2 (3)      "Item.2" -> 3
            PlayerPrefs.SetInt($"item.{items[i].id}", items[i].count);
        }
    }
    
    public void LoadItems()
    {
        for (var i = 0; i < items.Length; i++)
        {
            items[i].count = PlayerPrefs.GetInt($"item.{items[i].id}");
        }
    }
}
