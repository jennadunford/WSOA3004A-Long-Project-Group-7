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
            if(GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag== "Adventure")
            {
                Instantiate(adventureBook, pile[0]);

                adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[0].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                Instantiate(horrorBook, pile[0]);

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[0].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            } else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                Instantiate(fantasyBook, pile[0]);

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[0].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            } else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                Instantiate(romanceBook, pile[0]);

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[0].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                Instantiate(adventureBook, pile[1]);

                adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                Instantiate(horrorBook, pile[1]);

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            } else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                Instantiate(fantasyBook, pile[1]);

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            } else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                Instantiate(romanceBook, pile[1]);

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {
            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                Instantiate(adventureBook, pile[2]);

                adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[0].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                Instantiate(horrorBook, pile[2]);

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            } else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                Instantiate(fantasyBook, pile[2]);

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            } else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                Instantiate(romanceBook, pile[2]);

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {

            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                Instantiate(adventureBook, pile[3]);

                adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                Instantiate(horrorBook, pile[3]);

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            } else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                Instantiate(fantasyBook, pile[3]);

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            } else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                Instantiate(romanceBook, pile[3]);

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        else if (pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {

            if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Adventure")
            {
                Instantiate(adventureBook, pile[4]);

                adventureBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
            else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Horror")
            {
                Instantiate(horrorBook, pile[4]);

                horrorBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            } else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Fantasy")
            {
                Instantiate(fantasyBook, pile[4]);

                fantasyBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            } else if (GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag == "Romance")
            {
                Instantiate(romanceBook, pile[4]);

                romanceBook.tag = GameObject.FindGameObjectWithTag("Served").GetComponent<PatRequest>().patronChild.tag;

                pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
            }
        }
        






    }
}
