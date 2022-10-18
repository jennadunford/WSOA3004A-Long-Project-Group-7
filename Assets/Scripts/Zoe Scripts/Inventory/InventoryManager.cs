using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField]
    private GameObject inventField;

    public GameObject intakeBook;
    [System.NonSerialized]
    public int intakeNum;

    public bool inventFull = false;

    [SerializeField]
    private GameObject slot1;
    [SerializeField]
    private GameObject slot2;
    [SerializeField]
    private GameObject slot3;
    [SerializeField]
    private GameObject slot4;

    private bool[] emptyArray = new bool[5];
    private GameObject[] booksArray = new GameObject[5];
    private GameObject[] slotsArray = new GameObject[4];

    //[System.NonSerialized]
    public int inventContent = 0;

    //I am aware that I never actually use empty array and should remove it, but I intend to use it later, its a surprise tool for later yk
    private void Start()
    {
        //this loops sets every vairable in the array to true
        for (int i = 0; i < emptyArray.Length; i++)
        {
            emptyArray[i] = true;
        }

        slotsArray[0] = slot1;
        slotsArray[1] = slot2;
        slotsArray[2] = slot3;
        slotsArray[3] = slot4;
    }

    private void Update()
    {
        if (intakeNum > 0)
        {
            //instantiates the prefab that was just fetched, into the array
            booksArray[inventContent] = Instantiate(intakeBook, slotsArray[inventContent].transform.position, Quaternion.Euler(0, 0, 90), slotsArray[inventContent].transform) ;
            booksArray[inventContent].GetComponent<BookInteractionManager>().inInvent = true;
            intakeNum--;
            inventContent++;
        }

        if (inventContent == 4)
        {
            inventFull = true;
        } 
        else if (inventContent < 4)
        {
            inventFull = false;
        }

    }
}
