using System;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class ItemPickup : MonoBehaviour
{
    public float pickupRadius;
    public InventoryData ItemData;

    private SphereCollider collider;

    private void Awake()
    {
        collider = GetComponent<SphereCollider>();
        collider.isTrigger = true;
        collider.radius = pickupRadius;
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
