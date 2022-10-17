using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookPile : MonoBehaviour
{
    public Transform[] pile;
    
    public GameObject thebutton;
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
            
            Instantiate(thebutton, pile[0]);
            thebutton.tag = GameObject.FindGameObjectWithTag("Patron").GetComponent<PatRequest>().patronChild.tag;
            //thebutton.transform.parent = parentobject.transform;
            pile[0].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
        }
        else if (pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {

            Instantiate(thebutton, pile[1]);
            thebutton.tag = GameObject.FindGameObjectWithTag("Patron").GetComponent<PatRequest>().patronChild.tag;
            //thebutton.transform.parent = parentobject.transform;
            pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
        }
        else if (pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {

            Instantiate(thebutton, pile[2]);
            thebutton.tag = GameObject.FindGameObjectWithTag("Patron").GetComponent<PatRequest>().patronChild.tag;
            //thebutton.transform.parent = parentobject.transform;
            pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
        }
        else if (pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {

            Instantiate(thebutton, pile[3]);
            thebutton.tag = GameObject.FindGameObjectWithTag("Patron").GetComponent<PatRequest>().patronChild.tag;
            //thebutton.transform.parent = parentobject.transform;
            pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
        }
        else if (pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {

            Instantiate(thebutton, pile[4]);
            thebutton.tag = GameObject.FindGameObjectWithTag("Patron").GetComponent<PatRequest>().patronChild.tag;
            //thebutton.transform.parent = parentobject.transform;
            pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
        }
        else if (pile[5].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {

            Instantiate(thebutton, pile[5]);
            thebutton.tag = GameObject.FindGameObjectWithTag("Patron").GetComponent<PatRequest>().patronChild.tag;
            //thebutton.transform.parent = parentobject.transform;
            pile[5].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
        }
    }
}
