using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListManager : MonoBehaviour
{
    public bool oneEmpty;
    public bool twoEmpty;
    public bool threeEmpty;
    public bool fourEmpty;
    public bool fiveEmpty;
    public bool sixEmpty;

    public GameObject slotOne;
    public GameObject slotTwo;
    public GameObject slotThree;
    public GameObject slotFour;
    public GameObject slotFive;
    public GameObject slotSix;

    private List<GameObject> slotsList = new List<GameObject>();

    private void Start()
    {
        oneEmpty = true;
        twoEmpty = true;
        threeEmpty = true;
        fourEmpty = true;
        fiveEmpty = true;
        sixEmpty = true;
    }

private void Update()
    {
        //slotsList[0].GetComponent<Transform>().position = slotOne.GetComponent<Transform>().position;
        //slotsList[1].GetComponent<Transform>().position = slotTwo.GetComponent<Transform>().position;
        //slotsList[2].GetComponent<Transform>().position = slotThree.GetComponent<Transform>().position;
        //slotsList[3].GetComponent<Transform>().position = slotFour.GetComponent<Transform>().position;
        //slotsList[4].GetComponent<Transform>().position = slotFive.GetComponent<Transform>().position;
        //slotsList[5].GetComponent<Transform>().position = slotSix.GetComponent<Transform>().position;

        Debug.Log(oneEmpty);
    }

    public void AddBook()
    {
        if (oneEmpty)
        {
            slotsList.Add(gameObject);
            oneEmpty = false;
        }
        else if (twoEmpty)
        {
            slotsList.Add(gameObject);
            twoEmpty = false;
        }
        else if (threeEmpty)
        {
            slotsList.Add(gameObject);
            threeEmpty = false;
        }
        else if (fourEmpty)
        {
            slotsList.Add(gameObject);
            fourEmpty = false;
        }
        else if (fiveEmpty)
        {
            slotsList.Add(gameObject);
            fiveEmpty = false;
        }
        else if (sixEmpty)
        {
            slotsList.Add(gameObject);
            sixEmpty = false;
        }
        else 
        {
            Debug.Log("Inventory Full");
        }
    }
}
