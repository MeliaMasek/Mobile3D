using UnityEngine;

[CreateAssetMenu(menuName = "Inventory System/ Inventory Item")]
public class InventoryData : ScriptableObject
{
    public int ID;
    public string displayName;
    [TextArea(4, 4)]
    public string description;
    public Sprite icon;
    public int maxStackSize;
 }
