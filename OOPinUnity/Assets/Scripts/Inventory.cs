using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<InventoryItem> inventory;
    void Start()
    {
        inventory = new List<InventoryItem>();
    }

    
}
