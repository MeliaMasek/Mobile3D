using UnityEngine;
public class InventorySlot : MonoBehaviour
{
    public InventoryData itemData;
    public InventoryData ItemData => itemData;

    public int stacksize;
    public int StackSize => stacksize;

    public InventorySlot(InventoryData source, int amount)
    {
        itemData = source;
        stacksize = amount;
    }

    public InventorySlot()
    {
        ClearSlot();
    }

    public void ClearSlot()
    {
        itemData = null;
        stacksize = -1;
    }

    public bool RoomLeftInStack(int amountToAdd, out int amountRemaining)
    {
        amountRemaining = ItemData.maxStackSize - stacksize;
        return RoomLeftInStack(amountToAdd);
    }

    public bool RoomLeftInStack(int amountToAdd)
    {
        if (stacksize + amountToAdd <= itemData.maxStackSize)
            return true;
        else return false;
    }
    
    public void AddToStack(int amount)
    {
        stacksize += amount;
    }

    public void RemoveFromStack(int amount)
    {
        stacksize -= amount;
    }
}

