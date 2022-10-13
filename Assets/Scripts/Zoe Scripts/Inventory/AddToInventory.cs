using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToInventory : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private GameObject inventoryManager;

    //I made this a button function but I also know that in the game the books won't drop as a button, so feel free to use this however
    public void Add()
    {
        //set the intake book in the inventory manager
        inventoryManager.GetComponent<InventoryManager>().intakeBook = prefab;
        //increases intakeNum which tells the inventory manager to instantiate the prefab
        inventoryManager.GetComponent<InventoryManager>().intakeNum++;
        Destroy(gameObject);
    }
}
