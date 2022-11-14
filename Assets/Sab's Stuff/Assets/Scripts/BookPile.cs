using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookPile : MonoBehaviour
{
    public Transform[] pile;

    public GameObject returnedBook;

    public GameObject adventureBook;
    public GameObject horrorBook;
    public GameObject fantasyBook;
    public GameObject romanceBook;

    public GameObject parentobject;
    private void OnEnable()
    {
        //ClockController.OnDayChanged += AddBookToPile;

    }
    private void OnDisable()
    {
        //ClockController.OnDayChanged -= AddBookToPile;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



    }


    //this will check each slot of the book return pile. If there is book in the slot, it willl try us the next one. 
    public void AddBookToPile()
    {
        if (pile[0].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[0].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[0].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[0].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[0].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[0].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[0].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[0].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[0].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[0].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[0].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }

        }
        else if (pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[5].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[5].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[5].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[5].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[5].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[5].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[5].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[5].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[5].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[5].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[5].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[6].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[6].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[6].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[6].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[6].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[6].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[6].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[6].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[6].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[6].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[6].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[7].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[7].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[7].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[7].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[7].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[7].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[7].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[7].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[7].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[7].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[7].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }

        }
        else if (pile[8].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[8].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[8].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[8].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[8].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[8].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[8].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[8].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[8].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[8].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[8].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[9].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[9].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[9].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[9].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[9].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[9].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[9].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[9].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[9].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[9].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[9].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }


        }
        else if (pile[10].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[10].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[10].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[10].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[10].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[10].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[10].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[10].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[10].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[10].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[10].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[11].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[11].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[11].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[11].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[11].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[11].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[11].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[11].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[11].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[11].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[11].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[12].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[12].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[12].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[12].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[12].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[12].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[12].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[12].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[12].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[12].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[12].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[13].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[13].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[13].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[13].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[13].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[13].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[13].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[13].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[13].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[13].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[13].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[14].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[14].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[14].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[14].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[14].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[14].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[14].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[14].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[14].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[14].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[14].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[15].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[15].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[15].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[15].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[15].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[15].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[15].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[15].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[15].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[15].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[15].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[16].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[16].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[16].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[16].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[16].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[16].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[16].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[16].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[16].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[16].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[16].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[17].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[17].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[17].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[17].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[17].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[17].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[17].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[17].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[17].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[17].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[17].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[18].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[18].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[18].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[18].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[18].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[18].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[18].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[18].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[18].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[18].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[18].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }

        }
        else if (pile[19].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[19].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[19].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[19].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[19].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[19].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[19].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[19].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[19].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[19].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[19].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[20].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[20].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[20].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[20].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[20].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[20].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[20].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[20].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[20].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[20].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[20].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[21].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[21].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[21].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[21].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[21].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[21].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[21].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[21].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[21].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[21].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[21].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[22].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[22].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[22].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[22].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[22].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[22].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[22].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[22].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[22].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[22].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[22].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[23].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[23].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[23].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[23].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[23].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[23].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[23].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[23].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[23].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[23].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[23].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }

        }
        else if (pile[24].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[24].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[24].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[24].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[24].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[24].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[24].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[24].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[24].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[24].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[24].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[25].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[25].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[25].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[25].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[25].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[25].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[25].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[25].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[25].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[25].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[25].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }


        }
        else if (pile[26].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[26].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[26].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[26].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[26].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[26].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[26].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[26].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[26].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[26].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[26].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[27].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[27].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[27].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[27].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[27].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[27].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[27].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[27].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[27].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[27].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[27].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[28].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[28].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[28].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[28].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[28].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[28].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[28].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[28].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[28].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[28].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[28].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[29].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                //adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[29].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[29].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[29].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[29].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Horror")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[29].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[29].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[29].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Fantasy")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[29].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[29].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy Romance")
            {
                GameObject.FindGameObjectWithTag("InvoSlot").GetComponentInChildren<Return>().ReturnMe();

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[29].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
      
    }
}

