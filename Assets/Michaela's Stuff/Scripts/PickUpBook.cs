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
    //private GameObject inventoryManager;
    public GameObject BookCollected;

    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        //BookOne.SetActive(true);
        BookCollected.SetActive(false);
    }

    //void OnCollisionEnter2D(Collision col)
    //{
    //    if (col.gameObject.tag == "BookOne")
    //    {
    //        BookOne.SetActive(false);
    //        Debug.Log("Book collided");
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);

            Debug.Log("Book collided");

        }
    }

    private void OnDestroy()
    {
        //make the book in the inventory
        Debug.Log("Has Book");
        //set the intake book in the inventory manager
        //inventoryManager.GetComponent<InventoryManager>().intakeBook = BookOne;
        ////increases intakeNum which tells the inventory manager to instantiate the prefab
        //inventoryManager.GetComponent<InventoryManager>().intakeNum++;
        
        Destroy(gameObject);
        
        BookCollected.SetActive(true);

        //set the intake book in the inventory manager
        inventoryManager.GetComponent<InventoryManager>().intakeBook = prefab;
        //increases intakeNum which tells the inventory manager to instantiate the prefab
        inventoryManager.GetComponent<InventoryManager>().intakeNum++;
        Destroy(gameObject);
    }
}
