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
        }
    }
}

