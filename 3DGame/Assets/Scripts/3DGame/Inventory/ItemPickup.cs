using System;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class ItemPickup : MonoBehaviour
{
    public float pickupRadius;
    public InventoryData ItemData;

    private SphereCollider itemCollider;

    private void Awake()
    {
        itemCollider = GetComponent<SphereCollider>();
        itemCollider.isTrigger = true;
        itemCollider.radius = pickupRadius;
    }

    private void OnTriggerEnter(Collider other)
    {
        var inventory = other.transform.GetComponent<InventoryHolder>();
        if (!inventory) return;

        if (inventory.InventorySystem.AddToInventory(ItemData, 1))
        {
            Destroy(this.gameObject);
        }
    }
}
