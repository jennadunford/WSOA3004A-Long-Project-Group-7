using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddToInventory : MonoBehaviour
{
    [SerializeField]
    private GameObject slotManager;

    private InventoryManager bookScript;

    public void Start()
    {
        bookScript = slotManager.GetComponent<InventoryManager>();
    }
    public void AddBook()
    {
        if (slotManager.GetComponent<InventoryManager>().oneEmpty)
        {
            bookScript.slotOne.GetComponent<Image>().enabled = true;
            bookScript.slotOne.GetComponent<Image>().sprite = this.gameObject.GetComponent<Image>().sprite;
            bookScript.oneEmpty = false;
            this.gameObject.SetActive(false);
        }
        else if (slotManager.GetComponent<InventoryManager>().twoEmpty)
        {
            bookScript.slotTwo.GetComponent<Image>().enabled = true;
            bookScript.slotTwo.GetComponent<Image>().sprite = this.gameObject.GetComponent<Image>().sprite;
            bookScript.twoEmpty = false;
            this.gameObject.SetActive(false);
        }
        else if (slotManager.GetComponent<InventoryManager>().threeEmpty)
        {
            bookScript.slotThree.GetComponent<Image>().enabled = true;
            bookScript.slotThree.GetComponent<Image>().sprite = this.gameObject.GetComponent<Image>().sprite;
            bookScript.threeEmpty = false;
            this.gameObject.SetActive(false);
        }
        else if (slotManager.GetComponent<InventoryManager>().fourEmpty)
        {
            bookScript.slotFour.GetComponent<Image>().enabled = true;
            bookScript.slotFour.GetComponent<Image>().sprite = this.gameObject.GetComponent<Image>().sprite;
            bookScript.fourEmpty = false;
            this.gameObject.SetActive(false);
        }
        else if (slotManager.GetComponent<InventoryManager>().fiveEmpty)
        {
            bookScript.slotFive.GetComponent<Image>().enabled = true;
            bookScript.slotFive.GetComponent<Image>().sprite = this.gameObject.GetComponent<Image>().sprite;
            bookScript.fiveEmpty = false;
            this.gameObject.SetActive(false);
        }
        else if (slotManager.GetComponent<InventoryManager>().sixEmpty)
        {
            bookScript.slotSix.GetComponent<Image>().enabled = true;
            bookScript.slotSix.GetComponent<Image>().sprite = this.gameObject.GetComponent<Image>().sprite;
            bookScript.sixEmpty = false;
            this.gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("Inventory Full");
        }
    }
}
