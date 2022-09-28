using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddToInventory : MonoBehaviour
{
    [SerializeField]
    private GameObject slotManager;

    private InventoryManager bookScript;

    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private GameObject slotOne;
    [SerializeField]
    private GameObject slotTwo;
    [SerializeField]
    private GameObject slotThree;
    [SerializeField]
    private GameObject slotFour;
    [SerializeField]
    private GameObject slotFive;
    [SerializeField]
    private GameObject slotSix;

    [System.NonSerialized]
    public string inventorySlot;

    private Vector3 slotOnePos;
    private Vector3 slotTwoPos;
    private Vector3 slotThreePos;
    private Vector3 slotFourPos;
    private Vector3 slotFivePos;
    private Vector3 slotSixPos;

    private Quaternion myRotate;
    private Vector3 angleChange = new Vector3(0, 0, 90);

    public void Start()
    {
        bookScript = slotManager.GetComponent<InventoryManager>();
        myRotate.eulerAngles = angleChange;

        slotOnePos = slotOne.GetComponent<Transform>().position;
        slotTwoPos = slotTwo.GetComponent<Transform>().position;
        slotThreePos = slotThree.GetComponent<Transform>().position;
        slotFourPos = slotFour.GetComponent<Transform>().position;
        slotFivePos = slotFive.GetComponent<Transform>().position;
        slotSixPos = slotSix.GetComponent<Transform>().position;

    }
    public void AddBook()
    {
        if (slotManager.GetComponent<InventoryManager>().oneEmpty)
        {
            bookScript.oneEmpty = false;
            GameObject inventoryBookOne = Instantiate(prefab, slotOnePos, myRotate, slotOne.transform);
            inventoryBookOne.tag = "In Inventory";
            inventorySlot = "One";
            Destroy(gameObject);
        }
        else if (slotManager.GetComponent<InventoryManager>().twoEmpty)
        {
            bookScript.twoEmpty = false;
            GameObject inventoryBookTwo = Instantiate(prefab, slotTwoPos, myRotate, slotTwo.transform);
            inventoryBookTwo.tag = "In Inventory";
            inventorySlot = "Two";
            Destroy(gameObject);
        }
        else if (slotManager.GetComponent<InventoryManager>().threeEmpty)
        {
            bookScript.threeEmpty = false;
            GameObject inventoryBookThree = Instantiate(prefab, slotThreePos, myRotate, slotThree.transform);
            inventoryBookThree.tag = "In Inventory";
            inventorySlot = "Three";
            Destroy(gameObject);
        }
        else if (slotManager.GetComponent<InventoryManager>().fourEmpty)
        {
            bookScript.fourEmpty = false;
            GameObject inventoryBookFour = Instantiate(prefab, slotFourPos, myRotate, slotFour.transform);
            inventoryBookFour.tag = "In Inventory";
            inventorySlot = "Four";
            Destroy(gameObject);
        }
        else if (slotManager.GetComponent<InventoryManager>().fiveEmpty)
        {
            bookScript.fiveEmpty = false;
            GameObject inventoryBookFive = Instantiate(prefab, slotFivePos, myRotate, slotFive.transform);
            inventoryBookFive.tag = "In Inventory";
            inventorySlot = "Five";
            Destroy(gameObject);
        }
        else if (slotManager.GetComponent<InventoryManager>().sixEmpty)
        {
            bookScript.sixEmpty = false;
            GameObject inventoryBookSix = Instantiate(prefab, slotSixPos, myRotate, slotSix.transform);
            inventoryBookSix.tag = "In Inventory";
            inventorySlot = "Six";
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Inventory Full");
        }
    }
}
