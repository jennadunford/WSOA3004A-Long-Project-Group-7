using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpBook : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private GameObject inventoryManager;

    GameObject Player;
    public GameObject BookOne;
    public GameObject BookCollected;

    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        BookCollected.SetActive(false);
    }

    public void AddBook()
    {
        //set the intake book in the inventory manager
        inventoryManager.GetComponent<InventoryManager>().intakeBook = prefab;
        //increases intakeNum which tells the inventory manager to instantiate the prefab
        inventoryManager.GetComponent<InventoryManager>().intakeNum++;
        Destroy(gameObject);
    }
}
