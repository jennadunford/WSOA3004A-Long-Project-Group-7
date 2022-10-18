using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookPile : MonoBehaviour
{
    public Transform[] pile;
    
    public GameObject returnedBook;
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
            
            Instantiate(returnedBook, pile[0]);

            returnedBook.tag = GameObject.FindGameObjectWithTag("Patron").GetComponent<PatRequest>().patronChild.tag;
           
            pile[0].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
        }
        else if (pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {

            Instantiate(returnedBook, pile[1]);

            returnedBook.tag = GameObject.FindGameObjectWithTag("Patron").GetComponent<PatRequest>().patronChild.tag;

            pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
        }
        else if (pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {

            Instantiate(returnedBook, pile[2]);

            returnedBook.tag = GameObject.FindGameObjectWithTag("Patron").GetComponent<PatRequest>().patronChild.tag;

            pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
        }
        else if (pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {

            Instantiate(returnedBook, pile[3]);

            returnedBook.tag = GameObject.FindGameObjectWithTag("Patron").GetComponent<PatRequest>().patronChild.tag;

            pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
        }
        else if (pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {

            Instantiate(returnedBook, pile[4]);

            returnedBook.tag = GameObject.FindGameObjectWithTag("Patron").GetComponent<PatRequest>().patronChild.tag;

            pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
        }
        






    }
}
