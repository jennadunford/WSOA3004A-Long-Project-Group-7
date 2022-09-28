using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public bool oneEmpty = true;
    public bool twoEmpty = true;
    public bool threeEmpty = true;
    public bool fourEmpty = true;
    public bool fiveEmpty = true;
    public bool sixEmpty = true;

    public Image slotOne;
    public Image slotTwo;
    public Image slotThree;
    public Image slotFour;
    public Image slotFive;
    public Image slotSix;

    private List<Image> slotsList = new List<Image>();

    // Start is called before the first frame update
    void Start()
    {
        slotsList.Add(slotOne);
        slotsList.Add(slotTwo);
        slotsList.Add(slotThree);
        slotsList.Add(slotFour);
        slotsList.Add(slotFive);
        slotsList.Add(slotSix);
    }
}
