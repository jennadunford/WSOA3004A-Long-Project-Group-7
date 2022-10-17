using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookPile : MonoBehaviour
{
    public Transform[] pile;
    public List<Transform> pileSlots;
    public GameObject thebutton;
    public GameObject parentobject;
    public bool tester;
    // Start is called before the first frame update
    void Start()
    {
        //setting all the slots for the game o
        // pile[0].position = new Vector2(6.071018f, -0.9808334f);




    }

    // Update is called once per frame
    void Update()
    {
        //for (int i = 0; i < pile.Length; i++)
        //{
        //    if (pile[i] != null)
        //    {
        //        Instantiate(theButton, pile[i]);
        //        theButton.transform.parent = parentObject.transform;
        //        pile[i] = null;
        //    }
        //}


    }
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
            //thebutton.transform.parent = parentobject.transform;
            pile[1].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
        }
        else if (pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {

            Instantiate(thebutton, pile[2]);
            //thebutton.transform.parent = parentobject.transform;
            pile[2].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
        }
        else if (pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {

            Instantiate(thebutton, pile[3]);
            //thebutton.transform.parent = parentobject.transform;
            pile[3].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
        }
        else if (pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed == false)
        {

            Instantiate(thebutton, pile[4]);
            //thebutton.transform.parent = parentobject.transform;
            pile[4].gameObject.GetComponent<RemoveFromPile>().isUsed = true;
        }
    }
}
