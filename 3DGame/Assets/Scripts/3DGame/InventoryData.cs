using UnityEngine;

[CreateAssetMenu(menuName = "Inventory System")]
public class InventoryData : ScriptableObject
{
    public Sprite icon;

    public string description;
    public string displayName;
    [TextArea(4, 4)]
    
    public int maxStackSize;
    public int ID;
    



}
